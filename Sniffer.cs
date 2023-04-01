using System;
  class Sniffer
{
  private string name = Console.ReadLine();
  public string Name
{
    get{return name;}
    set{name = value;}
    }
    public void Dig()
    {
      string digging = $"{Name} is digging...";
      Console.WriteLine(digging);
    }
  }
    class Program
{
  static void Main(string[] args)
  {
  Sniffer a = new Sniffer();
  a.Dig();
  }
}
