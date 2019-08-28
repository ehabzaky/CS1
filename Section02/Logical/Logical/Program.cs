using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
  class Program
  {
    static void Main(string[] args)
    {
      int employeeAge = 40;
      int employmentYears = 5;
      bool isMarried = false;
      bool isReceivedPenalties = true;
      bool isBonus1Allowed = employeeAge > 30 && isMarried;
      Console.WriteLine(isBonus1Allowed);
      bool isBonus2Allowed = employeeAge > 30 || employmentYears > 10;
      Console.WriteLine(isBonus2Allowed);
      bool isBonus3Allowed = employmentYears > 20 && !isReceivedPenalties;
      Console.WriteLine(isBonus3Allowed);
    }
  }
}
