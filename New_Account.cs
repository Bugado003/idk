using System;
    class Account
{
     private string username = Console.ReadLine();
    public string Username
{
      get{return username;}
      set{username = value;}
      }
     private string password = Console.ReadLine();
      public string Password
{
        get{return password;}
        set{password = value;}
        }
    public void Nickname()
    {
      Console.WriteLine(Username);
      }
    public void Passwd()
    {
        string confirm_password = Console.ReadLine();
        if(Password == confirm_password)
        {
          Console.WriteLine($"Account created successfully \n Your Password: {Password}");
        }
        else
{
          Console.WriteLine("Passwords doesn't match");
        }
      }
}

  class Program{
    static void Main(string[] args){
      Account my_account = new Account();
      my_account.Nickname();
      my_account.Passwd();
    }
  }

