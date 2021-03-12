using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple
{
    // think this printer can perform all operations 
    public class MultiFunctionPrinter : IMachine
    {
        public void Fax(Document d)
        {
            // 
        }

        public void Print(Document d)
        {
            // 
        }

        public void Scan(Document d)
        {
            // 
        }
    }
}
