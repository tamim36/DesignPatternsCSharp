using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public class ColorAndSizeSpecification<T> : ISpecification<T>
    {
        ISpecification<T> first, second;
        public ColorAndSizeSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first;
            this.second = second;
        }

        public bool isSatisfied(T t)
        {
            return first.isSatisfied(t) && second.isSatisfied(t);
        }
    }
}
