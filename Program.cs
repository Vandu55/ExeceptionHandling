using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enteer frist number");
            int num1= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int  num2 = int.Parse(Console.ReadLine());
            try
            {
                int result = num1 / num2;
                Console.WriteLine("DEvsion result is :" + result);
            }
            catch
            
                (DivideByZeroException ex)
            {

                Console.WriteLine("You caanot divide a number by zero");
            }
            

            Console.WriteLine("REmaining  statement ");
            Console.ReadLine();
        }
    }
}
