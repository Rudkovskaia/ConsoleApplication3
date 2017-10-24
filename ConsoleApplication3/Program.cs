using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class CowClass
    {
        public static string Cow(int n)
        {
            string temp = "коров";

            int n1 = n % 10;
            int n2 = n % 100;

            if (10 < n2 && n2 < 20)
            {
                return temp;
            } else
            {
                if (n1 == 1)
                    return temp + "а";
                else
                {
                    if (n1 == 2 || n == 3 || n == 4)
                        return temp + "ы";
                    else
                        return temp;
                }
            }
        }

        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n + " " + Cow(n));

            Console.ReadLine();
        }
    }
}
