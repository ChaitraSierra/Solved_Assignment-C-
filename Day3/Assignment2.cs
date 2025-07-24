// Assignment 2: Library Management – Dictionary, HashSet, LinkedList
csharpCopyEditusing System;using System.Collections.Generic;
class Program{
    static void Main()
    {
        Dictionary<int, string> books = new Dictionary<int, string>
        {
            { 101, "C# Basics" },
            { 102, "Data Structures" },
            { 103, "LINQ in Action" }
        };

        HashSet<string> issuedBooks = new HashSet<string>();
        LinkedList<string> borrowQueue = new LinkedList<string>();

        // Borrow a bookstring bookToBorrow = books[102];
        if (issuedBooks.Add(bookToBorrow))
        {
            Console.WriteLine($"{bookToBorrow} issued.");
            borrowQueue.AddLast(bookToBorrow);
        }
        else        {
            Console.WriteLine($"{bookToBorrow} is already issued.");
        }

        // Return bookstring returnedBook = borrowQueue.First.Value;
        issuedBooks.Remove(returnedBook);
        borrowQueue.RemoveFirst();
        Console.WriteLine($"{returnedBook} returned.");
    }
}
