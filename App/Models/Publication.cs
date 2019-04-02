namespace console_library.Models
{
  abstract class Publication
  {
    public string Title { get; set; }
    public string Author { get; set; }

    public Publication(string title, string author)
    {
      Title = title;
      Author = author;
    }
  }
}