using System;
using System.Collections.Generic;
using System.Text;

namespace _14_Repeat_OOP
{
    class Pet : LiveObject, IPrintMe
    {
        public override string GetRace()
        {
            return nameof(Pet);
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{GetRace()}");
        }
    }
}
