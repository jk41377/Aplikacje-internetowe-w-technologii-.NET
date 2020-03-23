using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    public abstract class Party
    {
        public static void InviteToParty(Person person)
        {
            person.introduce();
            person.eat();
            person.dressUp();
            person.cheer();
        }
    }
}
