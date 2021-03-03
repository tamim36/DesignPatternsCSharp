using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    public class Journal
    {
        private readonly List<string> Entries = new List<string>();

        private static int count = 0;

        public int AddEntry(string text)
        {
            Entries.Add($"{++count} : {text}");
            return count;
        }

        public void RemoveEntry(int index)
        {
            Entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, Entries);
        }

        /*
        public void SaveToFile(string fileName, bool overwrite = false)
        {

        }

        * If we do this here will break the rule
        * one class have one responsibility and one reason to change.

        */
    }
}
