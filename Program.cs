using System;
using console_library.Models;

namespace console_library
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello Worlds!");

      Book whereTheSidewalkEnds = new Book("Where the Sidewalk Ends", "Shel Silverstein");
      Library stJohns = new Library("New York City", "St. John's");
      System.Console.WriteLine(whereTheSidewalkEnds.Title);
      System.Console.WriteLine(stJohns.Name);
    }

  }
}
