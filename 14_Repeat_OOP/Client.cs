using System;
using System.Collections.Generic;
using System.Text;

namespace _14_Repeat_OOP
{
    sealed class Client : Human
    {
        private static int _clientCount = 0;

        public Client(string name) : base (name)
        {
            Client._clientCount++;
            ClientId = Client._clientCount;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Client {GetRace()} {_name} ID: {ClientId}");
        }

        public int ClientId { get; set; }
    }
}
