using System;
using System.Linq;
using System.Collections.Generic;
namespace console_library.Models
{
  public class Library
  {
    //properties
    public string Location { get; set; }
    public string Name { get; set; }
    private List<Book> AvailableBooks { get; set; }
    private List<Book> CheckedOutBooks { get; set; }

    private List<Electronic> AvailableElectronics { get; set; }
    private List<Electronic> CheckedOutElectronics { get; set; }

    public void PrintAvailableBooks()
    {
      Console.Clear();
      System.Console.WriteLine(@"Please choose from the following options
      ");
      System.Console.WriteLine(@"Available Books: 
      ");

      for (int i = 0; i < AvailableBooks.Count; i++)
      {
        Book currentBook = AvailableBooks[i];
        Console.WriteLine($"{i + 1}) {AvailableBooks[i].Title} - {AvailableBooks[i].Author}");
      }
      System.Console.WriteLine(@"
Select a book number to check out, (R)eturn a book, view (E)lectronics, or (Q)uit");

    }

    public void PrintCheckedOutBooks()
    {
      Console.Clear();
      System.Console.WriteLine(@"Please choose from the following options
      ");
      System.Console.WriteLine(@"Returnable Books: 
      ");

      for (int i = 0; i < CheckedOutBooks.Count; i++)
      {
        Book currentBook = CheckedOutBooks[i];
        Console.WriteLine($"{i + 1}) {CheckedOutBooks[i].Title} - {CheckedOutBooks[i].Author}");
      }
      System.Console.WriteLine(@"
Select a book number to return, view (A)vailable books, view (E)lectronics, or (Q)uit");

    }

    internal void PrintAvailableElectronics()
    {
      Console.Clear();
      System.Console.WriteLine(@"Please choose from the following options
      ");
      System.Console.WriteLine(@"Available Electronics: 
      ");

      for (int i = 0; i < AvailableElectronics.Count; i++)
      {
        Electronic currentElectronic = AvailableElectronics[i];
        Console.WriteLine($"{i + 1}) {AvailableElectronics[i].DeviceName}");
      }
      System.Console.WriteLine(@"
Select an electronic number to check out, (L) to return electronics, view (A)vailable books, or (Q)uit");

    }
    internal void PrintCheckedOutElectronics()
    {
      Console.Clear();
      System.Console.WriteLine(@"Please choose from the following options
      ");
      System.Console.WriteLine(@"Checked out Electronics: 
      ");

      for (int i = 0; i < CheckedOutElectronics.Count; i++)
      {
        Electronic currentElectronic = CheckedOutElectronics[i];
        Console.WriteLine($"{i + 1}) {CheckedOutElectronics[i].DeviceName}");
      }
      System.Console.WriteLine(@"
Select an electronic number to return, view available (E)lectronics, view (A)vailable books, or (Q)uit");

    }


    internal void CheckoutElectronics(string input)
    {
      Electronic selectedElectronic = ValidateElectronic(input, AvailableElectronics);
      if (selectedElectronic == null)
      {
        Console.Clear();
        System.Console.WriteLine("Invalid Selection... Press enter to continue");
        Console.ReadLine();
        return;
      }
      //set available to false, add book to checked out and remove from available array
      selectedElectronic.Available = false;
      CheckedOutElectronics.Add(selectedElectronic);
      AvailableElectronics.Remove(selectedElectronic);
      Console.Clear();
      System.Console.WriteLine($"Enjoy the {selectedElectronic.DeviceName}");
    }

    internal void ReturnElectronics(string input)
    {
      Electronic selectedElectronic = ValidateElectronic(input, CheckedOutElectronics);
      if (selectedElectronic == null)
      {
        Console.Clear();
        System.Console.WriteLine("Invalid Selection... Press enter to continue");
        Console.ReadLine();
        return;
      }
      //set available to false, add book to checked out and remove from available array
      selectedElectronic.Available = true;
      AvailableElectronics.Add(selectedElectronic);
      CheckedOutElectronics.Remove(selectedElectronic);
      Console.Clear();
      System.Console.WriteLine($"Thanks for returning {selectedElectronic.DeviceName}!");
    }

    public void CheckoutBook(string input)
    {
      Book selectedBook = ValidateBook(input, AvailableBooks);
      if (selectedBook == null)
      {
        Console.Clear();
        System.Console.WriteLine("Invalid Selection... Press enter to continue");
        Console.ReadLine();
        return;
      }
      //set available to false, add book to checked out and remove from available array
      selectedBook.Available = false;
      CheckedOutBooks.Add(selectedBook);
      AvailableBooks.Remove(selectedBook);
      Console.Clear();
      System.Console.WriteLine($"Enjoy {selectedBook.Title}");
    }
    public void ReturnBook(string input)
    {
      Book selectedBook = ValidateBook(input, CheckedOutBooks);
      if (selectedBook == null)
      {
        Console.Clear();
        System.Console.WriteLine("Invalid Selection... Press enter to continue");
        Console.ReadLine();
        return;
      }
      //set available to false, add book to checked out and remove from available array
      selectedBook.Available = true;
      AvailableBooks.Add(selectedBook);
      CheckedOutBooks.Remove(selectedBook);
      Console.Clear();
      System.Console.WriteLine($"Thanks for returning {selectedBook.Title}!");
    }

    internal void AddLaptop(Laptop laptop)
    {
      AvailableElectronics.Add(laptop);
    }

    internal void addBook(Book book)
    {
      AvailableBooks.Add(book);
    }

    private Book ValidateBook(string input, List<Book> booksList)
    {
      // is a number
      int bookIndex;
      if (Int32.TryParse(input, out bookIndex) && bookIndex > 0 && bookIndex <= booksList.Count)
      {
        return booksList[bookIndex - 1];
      }
      return null;
    }

    private Electronic ValidateElectronic(string input, List<Electronic> electronicList)
    {
      // is a number
      int electronicIndex;
      if (Int32.TryParse(input, out electronicIndex) && electronicIndex > 0 && electronicIndex <= electronicList.Count)
      {
        return electronicList[electronicIndex - 1];
      }
      return null;
    }

    public void LastBook()
    {
      System.Console.WriteLine(AvailableBooks.Last().Title);
      System.Console.WriteLine("Here is the last book. Press enter to continue");
      Console.ReadLine();
    }

    public Library(string location, string name)
    {
      Location = location;
      Name = name;
      AvailableBooks = new List<Book>();
      CheckedOutBooks = new List<Book>();
      AvailableElectronics = new List<Electronic>();
      CheckedOutElectronics = new List<Electronic>();

    }



  }
}