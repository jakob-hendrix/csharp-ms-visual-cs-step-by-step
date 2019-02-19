using System;
using System.Linq;
using BinaryTree;

namespace QueryBinaryTree
{
    class Program
    {
        static void doWork()
        {
            // Build test cases
            Tree<Employee> empTree = new Tree<Employee>(new Employee { Id = 1, FirstName = "Kim", LastName = "Abercrombie", Department = "IT" });
            empTree.Insert(new Employee { Id = 2, FirstName = "Jeff", LastName = "Hay", Department = "Marketing" });
            empTree.Insert(new Employee { Id = 4, FirstName = "Charlie", LastName = "Herb", Department = "IT" });
            empTree.Insert(new Employee { Id = 6, FirstName = "Chris", LastName = "Preston", Department = "Sales" });
            empTree.Insert(new Employee { Id = 3, FirstName = "Dave", LastName = "Barnett", Department = "Sales" });
            empTree.Insert(new Employee { Id = 5, FirstName = "Tim", LastName = "Litton", Department = "Marketing" });

            Console.WriteLine("List of departments");
            var depts = empTree.Select(d => d.Department)
                                             ;

            foreach (var dept in depts)
            {
                Console.WriteLine($"Department: {dept}");
            }

        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
