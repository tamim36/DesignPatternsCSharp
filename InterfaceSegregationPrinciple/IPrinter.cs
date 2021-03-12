using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple
{
    // big interface segregates to small interface
    public interface IPrinter
    {
        void Print(Document d);
    }
}
