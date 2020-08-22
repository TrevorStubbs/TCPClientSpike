using System;

namespace GameServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Game Server";

            GameServer.Start(4, 26950);

            Console.ReadKey();
        }
    }
}
