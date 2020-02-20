using System;

namespace EchoClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Client Client = new Client();
            Client.Start();
        }
    }
}
