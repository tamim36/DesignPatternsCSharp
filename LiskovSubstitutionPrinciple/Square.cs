using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    public class Square : Rectangle
    {
        // insteed of using public new int should override 
        public override int height
        {
            set { base.width = base.height = value; }
        }

        public override int width
        {
            set { base.width = base.height = value; }
        }
    }
}
