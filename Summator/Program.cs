using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public class Program
    {
        static void Main(string[] args)
        {
            long result = Summator.Sum(new int[] { 1, 2, 3, 4, 5, 6, });
            if(result == 20)
            {
                Console.WriteLine("TEST PASS");
            }else
            {
                Console.WriteLine("TEST FAIL");
            }
        }
    }
}
