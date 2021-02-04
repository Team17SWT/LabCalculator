using System;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the calculator!");
            var calc = new Calculator();
            
            Console.WriteLine("Please enter two numbers you wish to add - if decimal, use ,");
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var add = calc.Add(a, b);

            Console.WriteLine($"{a} + {b} is: {add}");

            Console.WriteLine("Please enter two numbers you wish to subtract - if decimal, use ,");
            var c = double.Parse(Console.ReadLine());
            var d = double.Parse(Console.ReadLine());
            var sub = calc.Subtract(c, d);
            Console.WriteLine($"{c} - {d} is: {sub}");

            Console.WriteLine("Please enter two numbers you wish to multiply - if decimal, use ,");
            var e = double.Parse(Console.ReadLine());
            var f = double.Parse(Console.ReadLine());
            var mul = calc.Multiply(e, f);
            Console.WriteLine($"{e} * {f} is: {mul} ");

            Console.WriteLine("Please enter two numbers: First number is the one you want to get powered. Second is in which power - if decimal, use ,");
            var g = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var pow = calc.Power(g, h);
            Console.WriteLine($"{g} ^ {h} is {pow}");
        }

    }
}
