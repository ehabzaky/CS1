using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
  class Program
  {
    static void Main(string[] args)
    {
      int Number1 = 3;
      int Number2 = 10;
      int Number3 = 7;
      int sum = Number1 + Number2;
      Console.WriteLine(sum);
      int difference = Number2 - Number1;
      Console.WriteLine(difference);
      int multiply = Number1 * Number2;
      Console.WriteLine(multiply);
      int division = Number2 / Number1;
      Console.WriteLine(division);
      double realDivision = (double)Number2 / (double)Number1;
      Console.WriteLine(realDivision);
      int remainder = Number2 % Number1;
      Console.WriteLine(remainder);

      int complex = Number1 + Number2 * Number3;
      Console.WriteLine(complex);
      int parentheses = (Number1 + Number2) * Number3;
      Console.WriteLine(parentheses);

      string firstName = "Ehab";
      string lastName = "Zaky";
      string fullName = firstName + " " + lastName;
      Console.WriteLine(fullName);

      /* The following operation is not possible
       * as byte and short data types does not
       * allow basic mathematical operations */

      //short shortNumber1 = 5;
      //short shortNumber2 = 10;
      //short shortNumber3 = shortNumber1 + shortNumber2;

      Number1++;
      Console.WriteLine(Number1);
      Number2--;
      Console.WriteLine(Number2);
      // Here Number4 will be assigned Number3 value first, then Number3 is being incremented.
      int Number4 = Number3++;
      Console.WriteLine(Number4);
      // Here Number4 will be decremented first, then Number5 assigned the new value.
      int Number5 = --Number4;
      Console.WriteLine(Number5);
    }
  }
}
