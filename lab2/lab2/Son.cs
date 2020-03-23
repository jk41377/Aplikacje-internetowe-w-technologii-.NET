using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Son : Person
    {
        public Son(string name, string surname) : base(name, surname) { }

        public override void dressUp()
        {
            Console.WriteLine("SON DRESSES HIS TRACKSUIT");
        }

        public override void eat()
        {
            Console.WriteLine("SON EATS SALAD");
        }

        public override void cheer()
        {
            Console.WriteLine("THIS PARTY ROCKS!!!");
        }
    }
}
