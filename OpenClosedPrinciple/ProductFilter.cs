using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    /// <summary>
    /// Breaking open closed principle as each time its need modification
    /// </summary>
    public class ProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var product in products)
            {
                if (product.size == size)
                    yield return product;
            }
        }

        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var product in products)
            {
                if (product.color == color)
                    yield return product;
            }
        }

        public IEnumerable<Product> FilterByColorSize(IEnumerable<Product> products, Color color, Size size)
        {
            foreach (var product in products)
            {
                if (product.color == color && product.size == size)
                    yield return product;
            }
        }
    }
}
