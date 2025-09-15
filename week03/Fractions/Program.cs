using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine($"The first fraction is: {fraction1.GetFractionString()}");
        Console.WriteLine($"The second fraction is: {fraction2.GetFractionString()}");
        Console.WriteLine($"The third fraction is: {fraction3.GetFractionString()}");
        Console.WriteLine($"The decimal value of the first fraction is: {fraction1.GetDecimalValue()}");
        Console.WriteLine($"The decimal value of the second fraction is: {fraction2.GetDecimalValue()}");
        Console.WriteLine($"The decimal value of the third fraction is: {fraction3.GetDecimalValue()}");
        fraction1.SetTop(2);
        fraction1.SetBottom(3);
        Console.WriteLine($"The first fraction is now: {fraction1.GetFractionString()}");
        Console.WriteLine($"The decimal value of the first fraction is now: {fraction1.Get.DecimalValue()}");   
    }

  
}