using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Father : Person
    { 
        public Father(string name, string surname) : base(name, surname) { }

        public override void dressUp()
        {
            Console.WriteLine("FATHER DRESSES HIS SUIT");
        }

        public override void eat()
        {
            Console.WriteLine("FATHER TAKES A HUGE BITE OF MEAT");
        }

        public override void cheer()
        {
            Console.WriteLine("SPLENDID BANQUET.");
        }
    } 
}
