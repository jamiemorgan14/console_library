using console_library.Interfaces;

namespace console_library.Models
{
  class Laptop : Electronic
  {
    public int ScreenSize { get; set; }

    public Laptop(string deviceName, int screenSize) : base(deviceName)
    {
      ScreenSize = screenSize;
    }

    //property


  }
}