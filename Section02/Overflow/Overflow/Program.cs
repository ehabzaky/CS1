using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overflow
{
  class Program
  {
    static void Main(string[] args)
    {
      //int myInt = 3000000000;
      //int myInt = 1000000000 + 2000000000;

      checked
      {
        int firstNumber = 1000000000;
        int secondNumber = 2000000000;
        int thirdNumber = firstNumber + secondNumber;
        Console.WriteLine(thirdNumber);
      }
    }
  }
}
