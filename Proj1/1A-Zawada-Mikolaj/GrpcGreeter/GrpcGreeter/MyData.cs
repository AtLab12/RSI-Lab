using System;
using System.Net;
using System.Net.Sockets;

namespace GrpcGreeter
{
    public class MyData
    {
        public static void info()
        {
            Console.WriteLine("Płóciennik Tomasz 260404");
            Console.WriteLine("Zawada Mikołaj 259431");
            Console.WriteLine(DateTime.Now.ToString("dd MMMM, HH:mm:ss", new System.Globalization.CultureInfo("pl-PL")));
            Console.WriteLine(Environment.Version);
            Console.WriteLine(Environment.UserName);
            Console.WriteLine(Environment.OSVersion);

            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress addr in localIPs)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    Console.WriteLine(addr.ToString());
                }
            }
        }
    }
}

