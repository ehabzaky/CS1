using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison
{
  class Program
  {
    static void Main(string[] args)
    {
      int Number1 = 5;
      int Number2 = 10;
      bool isGreater = Number1 > Number2;
      Console.WriteLine(isGreater);
      bool isGreaterOrEqual = Number1 >= Number2;
      Console.WriteLine(isGreaterOrEqual);
      bool isLess = Number1 < Number2;
      Console.WriteLine(isLess);
      bool isLessOrEqual = Number1 <= Number2;
      Console.WriteLine(isLessOrEqual);
      bool isEqual = Number1 == Number2;
      Console.WriteLine(isEqual);
      bool isNotEqual = Number1 != Number2;
      Console.WriteLine(isNotEqual);
    }
  }
}
