using System;
using System.Collections.Generic;
using System.Text;

namespace _14_Repeat_OOP
{
    class Human : LiveObject, IPrintMe
    {
        protected string _name;

        public override string GetRace()
        {
            return nameof(Human);
        }

        public Human(string name)
        {
            _name = name;
        }

        ~Human() { }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{GetRace()} {_name}");
        }
    }
}
