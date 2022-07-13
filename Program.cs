using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            udp s = new udp();
            s.Server("0.0.0.0", 443);

            Console.ReadKey();
        }

    }
}




    

