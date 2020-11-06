using System;

namespace _14_Repeat_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Human boss = new Human("Vytautas");
            Company company = new Company(boss, "Maxima");

            company.OfficePet = new Dog("Doggo");

            company.HireWorker(new Worker("Valytojas Jonas", 460));
            company.HireWorker(new Worker("Programuotojas Petras", 2500));

            company.AddClient(new Client("Kestas"));
            company.AddClient(new Client("Ona"));

            company.PrintInfo();

            Console.ReadLine();
        }
    }
}
