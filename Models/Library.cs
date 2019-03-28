using System;
using System.Collections.Generic;
namespace console_library.Models
{
  public class Library
  {
    //properties
    public string Location { get; set; }
    public string Name { get; set; }
    private List<Book> Books { get; set; }
    private List<Book> CheckedOut { get; set; }

    public void PrintBooks()
    {
      Console.Clear();
      System.Console.WriteLine(@"Please choose from the following options
      ");
      System.Console.WriteLine(@"Available Books: 
      ");

      for (int i = 0; i < Books.Count; i++)
      {
        Book currentBook = Books[i];
        Console.WriteLine($"{i + 1}) {Books[i].Title} - {Books[i].Author}");
      }
      System.Console.WriteLine(@"
Select a book number to check out (Q)uit or (R)eturn a book");

    }

    public void Checkout(string input)
    {
      Book selectedBook = ValidateBook(input);
      if (selectedBook == null)
      {
        Console.Clear();
        System.Console.WriteLine("Invalid Selection");
        return;
      }
      selectedBook.Available = false;
      CheckedOut.Add(selectedBook);
      Books.Remove(selectedBook);
      Console.Clear();
      System.Console.WriteLine("SUCCESSFUL!");
    }

    internal void addBook(Book book)
    {
      Books.Add(book);
    }

    private Book ValidateBook(string input)
    {
      // is a number
      int bookIndex;
      if (Int32.TryParse(input, out bookIndex) && bookIndex > 0 && bookIndex < Books.Count)
      {
        return Books[bookIndex - 1];
      }
      return null;
    }

    public Library(string location, string name)
    {
      Location = location;
      Name = name;
      Books = new List<Book>();
      CheckedOut = new List<Book>();

    }



  }
}