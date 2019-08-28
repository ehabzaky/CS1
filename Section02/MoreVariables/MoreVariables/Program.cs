using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreVariables
{
  class Program
  {
    static void Main(string[] args)
    {
      // Byte
      byte MyByte = 10;
      Console.WriteLine(MyByte);
      Console.WriteLine(MyByte.GetType());
      // Signed Byte
      sbyte MySignedByte = 30;
      Console.WriteLine(MySignedByte);
      Console.WriteLine(MySignedByte.GetType());
      // Short
      short MyShort = 50;
      Console.WriteLine(MyShort);
      Console.WriteLine(MyShort.GetType());
      // Unsigned Short
      ushort MyUnsignedShort = 200;
      Console.WriteLine(MyUnsignedShort);
      Console.WriteLine(MyUnsignedShort.GetType());
      // Integer
      int MyInteger = 1000;
      Console.WriteLine(MyInteger);
      Console.WriteLine(MyInteger.GetType());
      // Unsigned Integer
      uint myUnsignedInteger = 500000;
      Console.WriteLine(myUnsignedInteger);
      Console.WriteLine(myUnsignedInteger.GetType());
      // Long
      long myLong = 7000000;
      Console.WriteLine(myLong);
      Console.WriteLine(myLong.GetType());
      // Unsigned Long
      ulong myUnsignedLong = 9000000000;
      Console.WriteLine(myUnsignedLong);
      Console.WriteLine(myUnsignedLong.GetType());
    }
  }
}
