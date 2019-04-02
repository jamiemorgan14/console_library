using System;
using console_library.Models;

namespace console_library
{
  class App
  {
    public void run()
    {
      Library myLibrary = new Library("New York City", "St. Johns");

      Book whereTheSidewalkEnds = new Book("Where the Sidewalk Ends", "Shel Silverstein", "1992");
      Book wool = new Book("Wool", "Hugh Howey", "2010");
      Book HPSS = new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", "1997");
      Book EII = new Book("Everything is Illuminated", "Jonathan Safran Foer", "2000");
      Book DIWC = new Book("Devil in the White City", "Erik Larson", "2016");
      Laptop mbp = new Laptop("Macbook Pro", 15);
      Laptop dell = new Laptop("Dell", 11);
      myLibrary.addBook(whereTheSidewalkEnds);
      myLibrary.addBook(wool);
      myLibrary.addBook(HPSS);
      myLibrary.addBook(EII);
      myLibrary.addBook(DIWC);


      System.Console.WriteLine("Welcome to the Library");
      Enum activeMenu = Menus.CheckoutBook;
      bool inLibrary = true;

      while (inLibrary)
      {
        switch (activeMenu)
        {
          case Menus.CheckoutBook:
            myLibrary.PrintBooks();
            break;
          case Menus.ReturnBook:
            myLibrary.PrintCheckedOut();
            break;
        }
        string input = Console.ReadLine();


        switch (input.ToUpper()[0])
        {
          case 'Q':
            inLibrary = false;
            break;
          case 'R':
            activeMenu = Menus.ReturnBook;
            break;
          case 'A':
            activeMenu = Menus.CheckoutBook;
            break;
          default:
            if (activeMenu.Equals(Menus.CheckoutBook))
            {
              myLibrary.Checkout(input);
            }
            else
            {
              myLibrary.Return(input);
            }
            break;
        }
      }
      System.Console.WriteLine("Goodbye!");
    }
  }

  public enum Menus
  {
    CheckoutBook,
    ReturnBook,
    CheckoutElectronics,
    ReturnElectronics
  }
}
