﻿using System.Net;
using System.Net.Sockets;

namespace Randomize
{
    public class PortNumber
    {
        public static string FreeTcpPort()
        {
            TcpListener l = new TcpListener(IPAddress.Loopback, 0);
            l.Start();
            int port = ((IPEndPoint)l.LocalEndpoint).Port;
            l.Stop();
            return port.ToString();
        }
    }
}
