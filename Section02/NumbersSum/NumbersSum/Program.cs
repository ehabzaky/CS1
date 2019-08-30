using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersSum
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Please enter first number: ");
      int number1 = int.Parse(Console.ReadLine());
      Console.Write("Please enter second number: ");
      int number2 = int.Parse(Console.ReadLine());
      Console.Write(number1.ToString() + " + " + number2.ToString() + " = ");
      Console.WriteLine(number1 + number2);
    }
  }
}
