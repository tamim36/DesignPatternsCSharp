using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple
{
    public class Scanner : IScanner
    {
        public void Scan(Document d)
        {
            Console.WriteLine("IScanner scan");
        }
    }
}
