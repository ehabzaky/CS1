using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarKeyword
{
  class Program
  {
    static void Main(string[] args)
    {
      var myNumber1 = 5;
      Console.WriteLine(myNumber1.GetType());
      var myNumber2 = 2000000000;
      Console.WriteLine(myNumber2.GetType());
      var myNumber3 = 3000000000;
      Console.WriteLine(myNumber3.GetType());
      var myNumber4 = 30000000000;
      Console.WriteLine(myNumber4.GetType());
      var myNumber5 = 10000000000000000000;
      Console.WriteLine(myNumber5.GetType());
      //var myNumber6 = 100000000000000000000;
      //Console.WriteLine(myNumber6.GetType());

      var myRealNumber1 = 3.0;
      Console.WriteLine(myRealNumber1.GetType());
      var myRealNumber2 = 3.0f;
      Console.WriteLine(myRealNumber2.GetType());
      var myRealNumber3 = 3.0m;
      Console.WriteLine(myRealNumber3.GetType());

      var myName = "Ehab";
      Console.WriteLine(myName.GetType());
      var myFirstChar = 'E';
      Console.WriteLine(myFirstChar.GetType());
      var isSucceded = false;
      Console.WriteLine(isSucceded.GetType());
    }
  }
}
