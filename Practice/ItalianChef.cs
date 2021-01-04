using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class ItalianChef : Chef
    {
        // over riding the method
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes chicken parm");
        }
        public void MakePasta()
        {
            Console.Write("The Chef makes Pasta");
        }

    }
}
