using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVariables
{
  class Program
  {
    static void Main(string[] args)
    {
      /* Sample
       * comment
       * That
       * extends
       * to multiple
       * lines
       */
      int customerAge; // Variable initialization
      customerAge = 30; // Variable assignment
      Console.WriteLine(customerAge); // Printing variable value
      customerAge = 31;
      Console.WriteLine(customerAge);
      customerAge = 32;
      Console.WriteLine(customerAge);
      customerAge = 37;
      Console.WriteLine(customerAge);

      int employeeAge = 40;
      Console.WriteLine(employeeAge);
    }
  }
}
