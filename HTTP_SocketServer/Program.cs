using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HTTP_SocketServer
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting server...");
            TcpListener listener = new TcpListener(IPAddress.Any, 11000);
            listener.Start();

            while (true)
            {
                Socket client = listener.AcceptSocket();
                Server s = new Server(client);
                s.Run();
            }
        }
    }
}






            //if (client.Connected)
            //{
            //    while (true)
            //    {
            //        string request = sr.ReadLine();
            //        switch (request)
            //        {
            //            case "GET /date HTTP/1.1":
            //                break;
            //        }
            //    }

//}
