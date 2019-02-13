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