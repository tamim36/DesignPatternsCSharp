using System;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var journal = new Journal();
            journal.AddEntry("I cried today.");
            journal.AddEntry("I got a bug.");

            Console.WriteLine(journal);

            Persistence persistence = new Persistence();
            var fileName = @"d:\journal.txt";
            persistence.SaveToFile(journal, fileName, true);
        }
    }
}
