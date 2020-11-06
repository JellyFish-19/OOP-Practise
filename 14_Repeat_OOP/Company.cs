using System;
using System.Collections.Generic;
using System.Text;

namespace _14_Repeat_OOP
{
    class Company : IPrintMe
    {
        private Human _boss;
        private readonly string _name;
        private List<Client> _clientList = new List<Client>();
        private List<Worker> _workerList = new List<Worker>();
        public Pet OfficePet { get; set; }

        public void AddClient(Client client)
        {
            _clientList.Add(client);
        }

        public Company(Human boss, string name)
        {
            _boss = boss;
            _name = name;
        }

        ~Company() { }

        public void HireWorker(Worker worker)
        {
            _workerList.Add(worker);
        }

        public void FireWorker(Worker worker)
        {
            _workerList.Remove(worker);
        }

        public void PrintAllClients()
        {
            foreach (var client in _clientList)
            {
                client.PrintInfo();
            }
        }

        public void PrintAllWorkers()
        {
            foreach (var worker in _workerList)
            {
                worker.PrintInfo();
            }
        }

        public void PrintInfo()
        {
            Console.Write("BOSS: ");
            _boss.PrintInfo();
            Console.WriteLine();

            Console.Write("PET: ");
            OfficePet.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("WORKERS: ");
            PrintAllWorkers();
            Console.WriteLine();

            Console.WriteLine("CLIENTS: ");
            PrintAllClients();
            Console.WriteLine();
        }
    }
}
