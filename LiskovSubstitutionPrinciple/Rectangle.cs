using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    public class Rectangle
    {
        // make the property virtual so that it can be ovveride
        public virtual int width { get; set; }
        public virtual int height { get; set; }

        public Rectangle()
        {

        }

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public override string ToString()
        {
            return $"{nameof(width)} : {width} and {nameof(height)} : {height}";
        }
    }
}
