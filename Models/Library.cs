namespace console_library.Models
{
  public class Library
  {
    //properties
    public string Location { get; set; }
    public string Name { get; set; }

    public Library(string location, string name)
    {
      Location = location;
      Name = name;
    }

  }
}