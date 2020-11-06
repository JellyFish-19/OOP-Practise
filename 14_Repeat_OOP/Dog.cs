using System;
using System.Collections.Generic;
using System.Text;

namespace _14_Repeat_OOP
{
    class Dog : Pet
    {
        private string _name;

        public Dog(string name)
        {
            _name = name;
        }

        public override string GetRace()
        {
            return nameof(Dog);
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{GetRace()} {_name}");
        }
    }
}
