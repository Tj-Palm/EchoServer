﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace EchoClient
{
    class Client
    {
        public void Start()
        {
            TcpClient socket = new TcpClient("localhost", 7);

            using (socket)
            {
                NetworkStream ns = socket.GetStream();
                StreamWriter sw = new StreamWriter(ns);
                StreamReader sr = new StreamReader(ns);

                bool LoopExit = true;

                while (LoopExit)
                {
                    string message = Console.ReadLine();
                    if (message == "exit".ToUpper())
                    {
                        LoopExit = false;
                        continue;
                    }
                    sw.WriteLine(message);

                    string ServerResponse = sr.ReadLine();

                    Console.WriteLine("Console: " + ServerResponse);
                }
            }
        }
    }
}
