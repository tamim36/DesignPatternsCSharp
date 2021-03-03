using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public class ColorSpecification : ISpecification<Product>
    {
        private readonly Color color;

        public ColorSpecification(Color color)
        {
            this.color = color;
        }
        public bool isSatisfied(Product p)
        {
            return p.color == color;
        }
    }
}
