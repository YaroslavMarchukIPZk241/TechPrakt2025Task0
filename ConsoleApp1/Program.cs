using System;
class Program
{
    static void Main(string[] args)
    {
        
        if (double.TryParse(Console.ReadLine(), out double a) && double.TryParse(Console.ReadLine(), out double b))
            Console.WriteLine($"{a} + {b} = {a+b}");
        else
            Console.WriteLine("Некоректний ввід");
    }
}