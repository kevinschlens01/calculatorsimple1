using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcutorSimple1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int K1 = 0;
            int K2 = 0;
            int total = 0;
            int totalTwo = 0;
            int totalThree = 0;
            int totalFour = 0;

            Console.WriteLine("--Calcutor--");

            Console.WriteLine("Enter the fist number:");
            K1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the secund number:");
            K2= Convert.ToInt32(Console.ReadLine());

            total = K1 + K2;
            totalTwo = K1 - K2;
            totalThree = K1 * K2;
            totalFour = K1 / K2;


            Console.WriteLine("O resultado da soma é:" + total);
            Console.WriteLine("O resultado da subrtração é:" + totalTwo);
            Console.WriteLine("O resultado da multiplicação é:" + totalThree);
            Console.WriteLine("O resultado da divisão é:" + totalFour);

            Console.ReadLine();
        }
    }
}
