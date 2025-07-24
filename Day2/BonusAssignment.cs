// Bonus Assignment: OOP Integration Project – Library System
csharpCopyEditusing System;using System.Collections.Generic;
interface IBorrowable{
    void Borrow();
    void ReturnItem();
}
class LibraryItem{
    public string Title { get; set; }
    public int ID { get; set; }
    public bool IsAvailable { get; set; }
    public LibraryItem(string title, int id)
    {
        Title = title;
        ID = id;
        IsAvailable = true;
    }
    public virtual void Display()
    {
        Console.WriteLine($"ID: {ID}, Title: {Title}, Available: {IsAvailable}");
    }
}
class Book : LibraryItem, IBorrowable{
    public Book(string title, int id) : base(title, id) { }
    public void Borrow()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine($"{Title} has been borrowed.");
        }
        else        {
            Console.WriteLine($"{Title} is not available.");
        }
    }
    public void ReturnItem()
    {
        IsAvailable = true;
        Console.WriteLine($"{Title} has been returned.");
    }
}
class Magazine : LibraryItem{
    public Magazine(string title, int id) : base(title, id) { }
}

csharpCopyEdit// Main method class Program{
    static void Main(string[] args)
    {
        List<LibraryItem> items = new List<LibraryItem>
        {
            new Book("C# Programming", 1),
            new Magazine("Tech Monthly", 2),
            new Book("Data Structures", 3)
        };

        foreach (var item in items)
        {
            item.Display();

            if (item is IBorrowable borrowable)
            {
                borrowable.Borrow();
                borrowable.ReturnItem();
            }

            Console.WriteLine();
        }
    }
}
