using System;

namespace PacketSender
{
    public class Utils
    {
        public static void startupFunction()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "PacketSender v1.0 (C#)";

            Console.WriteLine("Packet Sender v1.0 by Yochran has loaded.\n");
        }

        public static String selectIP()
        {
            Console.Write("Enter the IP address you want to send packets to: ");
            Console.ForegroundColor = ConsoleColor.Green;
            String ip = Console.ReadLine();

            return ip;
        }

        public static int selectPort()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n" + "Enter the port you want to send the packets on: ");
            Console.ForegroundColor = ConsoleColor.Green;
            int port = 0;

            try
            {
                port = int.Parse(Console.ReadLine());
            }
            catch (SystemException)
            {
                Console.WriteLine("You wrote an invalid value. (Must Be Integer)");
            }

            return port;
        }

        public static double selectPackets()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n" + "How many packets per loop do you want to send: ");
            Console.ForegroundColor = ConsoleColor.Green;
            double packets = 0;
            try
            {
                packets = double.Parse(Console.ReadLine());
            }
            catch (SystemException)
            {
                Console.WriteLine("You wrote an invalid value. (Must Be Double, 15 digits max.)");
            }

            return packets;
        }
    }
}
