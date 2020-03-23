using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    public abstract class Person
    {
        private string name;
        private string surname;

        public Person(string _name, string _surname)
        {
            name = _name;
            surname = _surname;
        }

        public void introduce()
        {
            Console.WriteLine("I am " + name + " " + surname);
        }

        virtual public void dressUp()
        {
            Console.WriteLine("DRESSING UP");
        }

        abstract public void eat();
        abstract public void cheer();
    }
}
