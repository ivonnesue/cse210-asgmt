using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fr = new Fraction();

        fr.fraction();
        Console.WriteLine(fr.getFractionString());

        Fraction fraction2 = new Fraction();

        fraction2.fraction(6);
        Console.WriteLine(fraction2.getFractionString());
        
        Fraction fraction3 = new Fraction();

        fraction3.fraction(6,7);
        Console.WriteLine(fraction3.getFractionString());
        
        Fraction fraction4 = new Fraction();
        fraction4.fraction(3,4);
        Console.WriteLine(fraction4.getDecimalValue());

        //The output result is 6. Ask why
        Fraction fraction5 = new Fraction();
        fraction5.fraction(5,1);
        Console.WriteLine(fraction2.getTop());

        Fraction fraction6 = new Fraction();
        fraction6.fraction(1,3);
        Console.WriteLine(fraction6.getFractionString());

        Fraction fraction7 = new Fraction();
        fraction7.fraction(1,3);
        Console.WriteLine(fraction6.getDecimalValue());



    }
}