using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public class SizeSpecification : ISpecification<Product>
    {
        private readonly Size size;

        public SizeSpecification(Size size)
        {
            this.size = size;
        }
        public bool isSatisfied(Product p)
        {
            if (p.size == size)
                return true;
            else
                return false;
        }
    }
}
