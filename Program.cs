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
        new IPEndPoint(IPAddress.Any, 443);
        udp s = new udp();
        s.Server(IPAddress.Any, 443);

        Console.ReadKey();
    }

    }
}




    

