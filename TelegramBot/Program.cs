namespace TelegramBot
{
    using System;
    using Telegram.Bot;
    class Program
    {
        static void Main(string[] args)
        {
            var botClient = new TelegramBotClient(BotCredentials.BotToken);
            var me = botClient.GetMeAsync().Result;
            Console.WriteLine("Hello my name is {0}.", me.FirstName);
        }
    }
}
