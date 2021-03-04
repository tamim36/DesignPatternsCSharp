using System;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static public int Area(Rectangle r) => r.width * r.height;
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(2, 3);
            Console.WriteLine($"{r} has area of {Area(r)}");

            // Square sq = new Square(); // this shouldn't be used
            Rectangle sq = new Square(); // this should use and generate correct output
            sq.width = 4;
            Console.WriteLine($"{sq} has area of {Area(sq)}");
        }
    }
}
