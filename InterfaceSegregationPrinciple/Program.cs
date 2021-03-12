using System;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var scanner = new Scanner();
            var printer = new Printer();
            var multiFunctionDevice = new MultifunctionDevice(printer, scanner);

            var document = new Document();

            multiFunctionDevice.Print(document);
            multiFunctionDevice.Scan(document);
        }
    }
}
