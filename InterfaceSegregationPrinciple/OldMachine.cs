using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple
{
    // think this machine can only print but also other methods need to be implemented
    public class OldMachine : IMachine
    {
        public void Fax(Document d)
        {
            // 
        }

        public void Print(Document d)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }
    }
}
