using System;
using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    class Program
    {
        public static IEnumerable<Product> products;
        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Medium);

            Product[] products = { apple, tree, house };
            var pf = new ProductFilter();

            Console.WriteLine("By breaking Open Closed Principle (old)");
            foreach (var product in pf.FilterByColor(products, Color.Green))
            {
                // Console.WriteLine(product);
            }

            var openClosedFilter = new OpenCloseFilter();
            Console.WriteLine("By open closed Principle (new) ");

            foreach (var product in openClosedFilter.Filter(products, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("Color and size (new)");
            var filteredProducts = openClosedFilter.Filter(products,
                new ColorAndSizeSpecification<Product>(new ColorSpecification(Color.Blue), new SizeSpecification(Size.Medium)));

            foreach (var product in filteredProducts)
            {
                Console.WriteLine(product);
            }
        }
    }
}
