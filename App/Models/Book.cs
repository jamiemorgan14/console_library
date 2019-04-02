using console_library.Interfaces;

namespace console_library.Models
{
  class Book : Publication, ICheckoutable
  {
    public string DatePublished { get; set; }
    public bool Available { get; set; }

    public Book(string title, string author, string datePublished) : base(title, author)
    {
      DatePublished = datePublished;
    }

    //property


  }
}