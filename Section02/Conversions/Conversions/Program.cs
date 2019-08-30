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
      byte smallVariable = 50;
      int largeVariable = smallVariable;
      Console.WriteLine(largeVariable);

      int largeVariable2 = 70;
      byte smallVariable2 = (byte)largeVariable2;
      Console.WriteLine(smallVariable2);

      double carSpeed = 50.0;
      int intSpeed = (int)carSpeed;
      Console.WriteLine(intSpeed);

      int integerValue = 100;
      string convertedString = integerValue.ToString();
      Console.WriteLine(convertedString);

      short negativeNumber = -10;
      uint negativeContainer = (uint)negativeNumber;
      Console.WriteLine(negativeContainer);

      string stringNumber = "10";
      // Not possible
      //int convertedNumber = (int)stringNumber;
      int convertedNumber = Convert.ToInt32(stringNumber);
      Console.WriteLine(convertedNumber);

      int number1 = 95;
      string number1Converted = number1.ToString();
      Console.WriteLine(number1Converted);

      string number2 = "25";
      int number2Converted = int.Parse(number2);
      Console.WriteLine(number2Converted);

    }
  }
}
