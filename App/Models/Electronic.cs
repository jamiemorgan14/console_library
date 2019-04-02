namespace console_library.Models
{
  abstract class Electronic
  {
    public string DeviceName { get; set; }


    public Electronic(string deviceName)
    {
      DeviceName = deviceName;
    }

    //property


  }
}