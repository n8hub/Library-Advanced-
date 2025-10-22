using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Book book1 = new Book("AOT", "Nathan Roberts");
        book1.CheckOut();
        Book book2 = new Book("JJK", "Nathan Roberts");
        book2.CheckOut();
        Book book3 = new Book("Demon layer", "Nathan Roberts");
        Book book4 = new Book("Solo Levelling", "Nathan Roberts");

        Library library = new Library();
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);
        library.AddBook(book4);
        library.CheckOutBook("AOT");
        library.CheckOutBook("JJK");
        library.ReturnBook("AOT");
        Console.WriteLine("Available books:");
        library.ListAvailableBooks();

    }
}

public class Book
{
    private string title;
    private string author;
    private bool isCheckedOut;

    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
        this.isCheckedOut = false;
    }

    // Public getters
    public string Title {get { return title; } }

    public bool IsCheckedOut
    {
        get { return isCheckedOut; }
    }

    public void CheckOut()
    {
        isCheckedOut = true;
    }

    public void Return()
    {
        isCheckedOut = false;
    }




   
    
}
        public class Library
    {
        private List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
        }
    public void ListAvailableBooks()
    {
        foreach (Book book in books)
        {
            if (!book.IsCheckedOut)
            {
                Console.WriteLine(book.Title);
            }

        }
    }
    public void CheckOutBook(string title)
    {
        foreach (Book book in books)
        {
            if (book.Title == title && !book.IsCheckedOut)
            {
                book.CheckOut();
                Console.WriteLine($"{title} has been checked out.");
                return;
            }
        }

        Console.WriteLine($"{title} is either not available or already checked out.");
    }
    public void ReturnBook(string title)
        {
        foreach (Book book in books)
            {
                if (book.Title == title && book.IsCheckedOut)
                {
                    book.Return();
                    break;
                }
        }
    }
    }



