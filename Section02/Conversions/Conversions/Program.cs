using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
  class Program
  {
    static void Main(string[] args)
    {
      int integerValue = 100;
      string convertedString = integerValue.ToString();
      Console.WriteLine(convertedString);

      string stringNumber = "10";
      int convertedNumber = int.Parse(stringNumber);
      Console.WriteLine(convertedNumber);
    }
  }
}
