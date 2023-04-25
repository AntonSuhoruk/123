using System;
using MyLib1;

namespace Proverka 
{
    class proverka1
    {
        static void Main(string[] args)
        {
            calculation calculator = new calculation();
            Console.WriteLine("первое число");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("второе число");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("a = {0}, b={1}", a, b);
            Console.WriteLine("a + b = {0}", calculator.plus(a, b));
            Console.WriteLine("a - b = {0}", calculator.minus(a, b));
            Console.WriteLine("a * b = {0}", calculator.umnojit(a, b));
            Console.WriteLine("a / b = {0}", calculator.delit(a, b));
        }
    }
}
