namespace TelegramBot
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var bot = new BotWorker();
            bot.Inizalize();
            bot.Start();

            Console.WriteLine("type stop to quit");

            string command;
            do
            {
                command = Console.ReadLine();

            } while (command != "stop");

            bot.Stop();
        }
        
    }
}
