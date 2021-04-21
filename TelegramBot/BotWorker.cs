namespace TelegramBot
{
    using System;
    using Telegram.Bot;
    using Telegram.Bot.Args;
    class BotWorker
    {
        static ITelegramBotClient botClient;

        public void Inizalize()
        {
            botClient = new TelegramBotClient(BotCredentials.BotToken);
        }

        public void Start()
        {
            botClient.OnMessage += Bot_OnMessage;
            botClient.StartReceiving();
        }

        public void Stop()
        {
            botClient.StopReceiving();
        }

        static async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            if (e.Message.Text != null)
            {
                Console.WriteLine($"got a new msg in chat: {e.Message.Chat.Id}.");

                await botClient.SendTextMessageAsync(
                chatId: e.Message.Chat, text: "you type:\n" + e.Message.Text);
            }
        }
    }
}
