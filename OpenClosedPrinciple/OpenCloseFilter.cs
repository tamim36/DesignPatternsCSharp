using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public class OpenCloseFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var item in items)
            {
                if (spec.isSatisfied(item))
                {
                    yield return item;
                }
            }
        }

        public void show()
        {
            Console.WriteLine("will it print");
        }
    }
}
