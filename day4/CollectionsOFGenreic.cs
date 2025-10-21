using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsExample
{
    internal class Program
    {
        // Example 1: List<T>
        static void MainList()
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

            // Add
            numbers.Add(60);
            numbers.Insert(2, 25); // Insert at index

            // Remove
            numbers.Remove(40);
            numbers.RemoveAt(0); // remove by index

            // Search
            Console.WriteLine("Contains 30: " + numbers.Contains(30));
            Console.WriteLine("Index of 25: " + numbers.IndexOf(25));

            // Sort and Reverse
            numbers.Sort();
            numbers.Reverse();

            Console.WriteLine("\nList Elements:");
            foreach (var num in numbers)
                Console.WriteLine(num);
        }

        // Example 2: List<Employee>
        static void MainListEmployee()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{EmpNo=101, Name="Arslan"},
                new Employee{EmpNo=102, Name="Abdul"},
                new Employee{EmpNo=103, Name="Sneha"}
            };

            // Find
            var emp = employees.Find(e => e.EmpNo == 102);
            Console.WriteLine("\nFound Employee: " + emp.Name);

            // Remove
            employees.RemoveAll(e => e.Name.StartsWith("A"));

            Console.WriteLine("\nEmployee List after removal:");
            foreach (var e in employees)
                Console.WriteLine($"{e.EmpNo} - {e.Name}");
        }

        // Example 3: SortedList<TKey, TValue>
        static void MainSortedList()
        {
            SortedList<int, string> cities = new SortedList<int, string>();
            cities.Add(3, "Mumbai");
            cities.Add(1, "Delhi");
            cities.Add(2, "Kolkata");

            Console.WriteLine("\nSortedList (Key Sorted Automatically):");
            foreach (KeyValuePair<int, string> kv in cities)
                Console.WriteLine($"Key: {kv.Key}, Value: {kv.Value}");

            // Access by key and index
            Console.WriteLine("\nCity with key 1: " + cities[1]);
            Console.WriteLine("City at index 2: " + cities.Values[2]);

            // Remove by key or index
            cities.Remove(3);
            cities.RemoveAt(0);

            Console.WriteLine("\nAfter removals:");
            foreach (var kv in cities)
                Console.WriteLine($"{kv.Key} - {kv.Value}");
        }

        // Example 4: SortedList<int, Employee>
        static void MainSortedListEmployee()
        {
            SortedList<int, Employee> empList = new SortedList<int, Employee>()
            {
                { 101, new Employee { EmpNo = 101, Name = "Arslan" } },
                { 102, new Employee { EmpNo = 102, Name = "Abdul" } },
                { 103, new Employee { EmpNo = 103, Name = "Sneha" } }
            };

            Console.WriteLine("\nEmployee SortedList:");
            foreach (var kv in empList)
                Console.WriteLine($"{kv.Key} => {kv.Value.Name}");

            // Access, Update, Remove
            Console.WriteLine("\nAccess Employee 102: " + empList[102].Name);
            empList[103].Name = "Sania";
            empList.Remove(101);

            Console.WriteLine("\nAfter Updates:");
            foreach (var kv in empList)
                Console.WriteLine($"{kv.Key} => {kv.Value.Name}");
        }

        // Example 5: Stack & Queue demo
        static void MainStackQueue()
        {
            Stack<int> s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Console.WriteLine("\nStack Elements (LIFO):");
            while (s.Count > 0)
                Console.WriteLine(s.Pop());

            Queue<string> q = new Queue<string>();
            q.Enqueue("First");
            q.Enqueue("Second");
            q.Enqueue("Third");
            Console.WriteLine("\nQueue Elements (FIFO):");
            while (q.Count > 0)
                Console.WriteLine(q.Dequeue());
        }

        // You can call any static method here
        static void Main()
        {
            MainList();
            MainListEmployee();
            MainSortedList();
            MainSortedListEmployee();
            MainStackQueue();
        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string? Name { get; set; }
    }
}
