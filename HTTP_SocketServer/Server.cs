using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HTTP_SocketServer
{
    public class Server
    {
        Socket client;
        public Server(Socket client)
        {
            this.client = client;

        }


        public void Run()
        {
            NetworkStream ns = new NetworkStream(client);
            StreamWriter sw = new StreamWriter(ns, Encoding.ASCII) { AutoFlush = true };
            StreamReader sr = new StreamReader(ns, Encoding.ASCII);

            if (client.Connected)
            {
                while (true)
                {
                    string request = sr.ReadLine();
                    if (request != null)
                    {
                        switch (request)
                        {
                            case "GET /date HTTP/1.1":
                                break;
                        }
                    }
                   
                }

            }
        }
            

     }

    }

