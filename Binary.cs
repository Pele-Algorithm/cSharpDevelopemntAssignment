using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpAssignment
{
    using System;

    public class Binary
    {
        public static int BinaryMethod(int n)
        {
            int rem, i = 1, binary = 0;
            while (n != 0)
            {
                rem = n % 2; n /= 2; binary += rem * i; i *= 10;
            }
            return binary;
        }

        public static void Main()
        {
            int numS;
            Console.WriteLine("enter a number");
            bool success = int.TryParse(Console.ReadLine(), out numS);
            if (success)
            {
                int answer = BinaryMethod(numS);
                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine("please input a correct number");


            }
        }
    } 
 }

