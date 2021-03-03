using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    public class Persistence
    {
        public void SaveToFile(Journal journal, string fileName, bool overwrite = false)
        {
            if (overwrite || !File.Exists(fileName))
            {
                File.WriteAllText(fileName, journal.ToString());
            }
        }
    }
}
