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
            int recv;
            byte[] data = new byte[1024];

            IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, 443);

            Socket newSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            newSocket.Bind(endpoint);

            Console.WriteLine("Waiting for a client");

            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 443);

            EndPoint tmpRemote = (EndPoint)sender;


            recv = newSocket.ReceiveFrom(data, ref tmpRemote);


            Console.Write("Message recevied from {0}", tmpRemote.ToString());
            Console.WriteLine(Encoding.ASCII.GetString(data, 0, recv));

            string welcome = "My server";
            data = Encoding.ASCII.GetBytes(welcome);


            if (newSocket.Connected)
                newSocket.Send(data);
            while (true)
            {
                if(!newSocket.Connected)
                {
                    Console.WriteLine("Client Disconnected");
                    break;
                }


                data = new byte[1024];
                recv = newSocket.ReceiveFrom(data, ref tmpRemote);


                if (recv == 0)
                    break;

                Console.WriteLine(Encoding.ASCII.GetString(data, 0, recv));

            }

            newSocket.Close();


       
        }

    }


}