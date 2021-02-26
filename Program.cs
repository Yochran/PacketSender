using System;

namespace PacketSender
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Utils.startupFunction();

            String ip = Utils.selectIP();
            int port = Utils.selectPort();
            double packets = Utils.selectPackets();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n" + $"Sending {packets} packets per loop to {ip} on {port} port...\n");

            PacketUtils.sendPackets(ip, port, packets);
        }
    }
}
