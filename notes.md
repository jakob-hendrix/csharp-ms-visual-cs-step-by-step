# Notes from Microsoft Visual C# Step by Step 9e

## Useful Tidbits

* when using generics, you may use the `default(T)` keyword to initialize variables to whatever the default is for what `T` eventually resolves to at runtime. Example: `private TItem currentItem = default(TItem)`

## Conventions

### Error handling

* `InvalidOperationException` is how you would normally indicate that an operation coan not be performed in the current state

---

## Chapters

### Chapter 19 - enumeration

Each time `GetEnumerator()` is called, a new Enumerator object is built that knows how and in what order to return whatever object is being enumeratoed over.

On the otherhand, just use an *iterator* (...`yield return item`) unless otherwise called for.

### Chapter 20 - Delegates

Super powerful way to abstract behavior and implementation. Like little many interfaces, but with the ability to execute a bunch of methods that are not know by the executing entity.

**Method adapters** are a very common design pattern that use a method to give another one a new signature

```C#
public delegate void performActions();

// Takes the `Attack(weapon)` method and turns it into the equivalent sinature of `Attack()`
void AttackWithSword() {
    currentCharacter.Attack(sword);
}

// No usable with a delegate that accepts no param
this.performActions += currentCharacter.AttackWithSword();

// However, `lambda expressions` can replace these and mitigate any code stink their presence may cause.
this.performActions +=
    (
        () => currentCharacter.Attack(sword)
    )
```

#### Events

You typically declare `events` on classes desing to raise events call *event sources*. Each `event` maitains a list of *subscribers* (`InvokactionList`).

When events are *raised*, all attached delegates are called in sequence. When you add a method to the invocation (subscribe) list of an event, it makes the event not *null* and gives something for the event to invoke when it is raised.

In our example, `displayMessage` has the same signture as the delegates that formed the shape of the event...therefor when the event was raised by the two data classes, the UI handling event on the UI class was able to blindly accept data (through the delegate).

### Chapter 21 - LINQ

LINQ is a great way of accessing data from types that implement `IEnumerable<T>`. 

The `Select` method allows you to especify, or *project* the fields that you want from an enumerable collection.

The `Where` method alows you to filter data from being picked up by the `Select`.

`GroupBy` is great because it allows you to combine larges data sets.  It returns an enumerable set of groups, where each on is an enumerable set of rows.  The set of groups has a `key` property that aloos access into the type it is encapsulating.