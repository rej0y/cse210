using System;

class Program
{
    static void Main(string[] args)
    {
        // Fraction fraction1 = new Fraction();
        // Fraction fraction2 = new Fraction(6);
        // Fraction fraction3 = new Fraction(6, 7);

        // Console.WriteLine($"{fraction1.GetTop()}\n{fraction2.GetTop()}\n{fraction3.GetTop()}");
        // Console.WriteLine($"{fraction1.GetBottom()}\n{fraction2.GetBottom()}\n{fraction3.GetBottom()}");
        // Console.WriteLine($"{fraction1.GetFractionString()}\n{fraction2.GetFractionString()}\n{fraction3.GetFractionString()}");
        // Console.WriteLine($"{fraction1.GetDecimalValue()}\n{fraction2.GetDecimalValue()}\n{fraction3.GetDecimalValue()}");

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);

        Console.WriteLine($"{fraction1.GetFractionString()}\n{fraction1.GetDecimalValue()}");
        Console.WriteLine($"{fraction2.GetFractionString()}\n{fraction2.GetDecimalValue()}");
        Console.WriteLine($"{fraction3.GetFractionString()}\n{fraction3.GetDecimalValue()}");
        Console.WriteLine($"{fraction4.GetFractionString()}\n{fraction4.GetDecimalValue()}");

    }
}