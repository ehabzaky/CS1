using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Please enter a number: ");
      int number = int.Parse(Console.ReadLine());
      Console.Write(number.ToString() + " X 1 = ");
      Console.WriteLine(number * 1);
      Console.Write(number.ToString() + " X 2 = ");
      Console.WriteLine(number * 2);
      Console.Write(number.ToString() + " X 3 = ");
      Console.WriteLine(number * 3);
      Console.Write(number.ToString() + " X 4 = ");
      Console.WriteLine(number * 4);
      Console.Write(number.ToString() + " X 5 = ");
      Console.WriteLine(number * 5);
      Console.Write(number.ToString() + " X 6 = ");
      Console.WriteLine(number * 6);
      Console.Write(number.ToString() + " X 7 = ");
      Console.WriteLine(number * 7);
      Console.Write(number.ToString() + " X 8 = ");
      Console.WriteLine(number * 8);
      Console.Write(number.ToString() + " X 9 = ");
      Console.WriteLine(number * 9);
      Console.Write(number.ToString() + " X 10 = ");
      Console.WriteLine(number * 10);
    }
  }
}
