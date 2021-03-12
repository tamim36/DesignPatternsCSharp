using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple
{
    public class MultifunctionDevice : IMultifunctionDevice
    {
        private readonly IPrinter printer;
        private readonly IScanner scanner;

        public MultifunctionDevice(IPrinter printer, IScanner scanner)
        {
            this.printer = printer;
            this.scanner = scanner;
        }

        public void Print(Document d)
        {
            printer.Print(d);
        }

        public void Scan(Document d)
        {
            scanner.Scan(d);
        }
    } // decorator pattern
}
