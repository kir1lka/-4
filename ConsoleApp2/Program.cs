using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CustomMath
    {
        public static int sum(int x, int y)
        {
            return x + y;
        }
        public static int division(int x, int y)
        {
            if (y == 0)
                throw new InvalidOperationException("divider = 0”");
            else return x / y;
        }
        public static void Main(string[] args)
        {
            try
            {
                int z = division(1, 0);
                Console.WriteLine("Test3 failed");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Test3 passed");
            }
        }
        public static bool main(int x, int y)
        {
            bool result = true;
            if (y == 0)
                result = false;
            return result;
        }
    }
}
