using console_library.Interfaces;

namespace console_library.Models
{
  abstract class Electronic : ICheckoutable
  {
    public string DeviceName { get; set; }
    public bool Available { get; set; }

    public Electronic(string deviceName)
    {
      DeviceName = deviceName;
    }

    //property


  }
}