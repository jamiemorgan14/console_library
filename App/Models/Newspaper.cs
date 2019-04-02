namespace console_library.Models
{
  class Newspaper : Publication
  {
    public string CityAndState { get; set; }

    public Newspaper(string title, string author, string cityAndState) : base(title, author)
    {
      CityAndState = cityAndState;
    }

    //property


  }
}