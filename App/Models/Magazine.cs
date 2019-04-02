namespace console_library.Models
{
  class Magazine : Publication
  {
    public string MonthOfEdition { get; set; }

    public Magazine(string title, string author, string monthOfEdition) : base(title, author)
    {
      MonthOfEdition = monthOfEdition;
    }

    //property


  }
}