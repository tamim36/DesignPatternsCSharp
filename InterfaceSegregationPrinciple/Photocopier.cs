using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple
{
    public class Photocopier : IPrinter, IScanner
    {
        public void Print(Document d)
        {
            Console.WriteLine("Photocopier print");
        }

        public void Scan(Document d)
        {
            Console.WriteLine("Photocopier scan");
        }
    }
}
