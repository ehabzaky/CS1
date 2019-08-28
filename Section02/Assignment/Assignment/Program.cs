using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
  class Program
  {
    static void Main(string[] args)
    {
      int firstValue;

      firstValue = 10;
      // both lines are same
      //firstValue = firstValue + 10;
      firstValue += 10;
      Console.WriteLine(firstValue);

      firstValue = 5;
      // both lines are same
      //firstValue = firstValue - 2;
      firstValue -= 2;
      Console.WriteLine(firstValue);

      firstValue = 10;
      // both lines are same
      //firstValue = firstValue / 2;
      firstValue /= 2;
      Console.WriteLine(firstValue);

      firstValue = 5;
      // both lines are same
      //firstValue = firstValue * 2;
      firstValue *= 2;
      Console.WriteLine(firstValue);

      firstValue = 10;
      // both lines are same
      //firstValue = firstValue % 3;
      firstValue %= 3;
      Console.WriteLine(firstValue);

    }
  }
}
