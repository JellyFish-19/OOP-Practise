using System;
using System.Collections.Generic;
using System.Text;

namespace _14_Repeat_OOP
{
    sealed class Worker : Human
    {
        private int _salary;

        public Worker(string name, int salary) : base(name)
        {
            _name = name;
            _salary = salary;
        }

        public int GetSalary()
        {
            return _salary;
        }

        public void SetSalary(int salary)
        {
            _salary = salary;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Worker {GetRace()} {_name} ${GetSalary()}");
        }
    }
}
