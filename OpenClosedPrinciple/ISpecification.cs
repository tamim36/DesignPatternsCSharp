using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public interface ISpecification<T>
    {
        bool isSatisfied(T t);
    }
}
