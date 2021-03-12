using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple
{
    public class Printer : IPrinter
    {
        public void Print(Document d)
        {
            Console.WriteLine("IPrinter print");
        }
    }
}
