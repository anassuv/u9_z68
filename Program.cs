using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z
{
    class Program
    {
        static int aker(int m, int n)
        {
            int q = 0;
            if (m == 0) q = n + 1;
            if (m > 0 && n == 0) q = aker(m - 1, 1);
            if (m > 0 && n > 0) q = aker(m - 1, aker(m, n - 1));
            return q;
        }
        static void Main(string[] args)
        {
            Console.Write("M = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());            
            
            Console.Write("\nm = {0}, n = {1} -> A(m, n) = {2}\n\n", m, n, aker(m, n));

            Console.ReadKey();
        }
    }
}
