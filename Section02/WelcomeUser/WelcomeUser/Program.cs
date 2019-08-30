using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeUser
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("What is your name? ");
      string userName = Console.ReadLine();
      Console.Write("Welcome, ");
      Console.WriteLine(userName);
    }
  }
}
