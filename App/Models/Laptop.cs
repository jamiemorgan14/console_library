using console_library.Interfaces;

namespace console_library.Models
{
  class Laptop : Electronic, ICheckoutable
  {
    public int ScreenSize { get; set; }
    public bool Available { get; set; }

    public Laptop(string deviceName, int screenSize) : base(deviceName)
    {
      ScreenSize = screenSize;
    }

    //property


  }
}