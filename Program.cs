using System;
using console_library.Models;
using System.Collections.Generic;

namespace console_library
{
  class Program
  {
    static void Main(string[] args)
    {
      Library myLibrary = new Library("New York City", "St. Johns");

      Book whereTheSidewalkEnds = new Book("Where the Sidewalk Ends", "Shel Silverstein");
      Book wool = new Book("Wool", "Hugh Howey");
      Book HPSS = new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling");
      Book EII = new Book("Everything is Illuminated", "Jonathan Safran Foer");
      Book DIWC = new Book("Devil in the White City", "Erik Larson");

      myLibrary.addBook(whereTheSidewalkEnds);
      myLibrary.addBook(wool);
      myLibrary.addBook(HPSS);
      myLibrary.addBook(EII);
      myLibrary.addBook(DIWC);



      myLibrary.PrintBooks();
      string input = Console.ReadLine();
      myLibrary.Checkout(input);
    }
  }
}
