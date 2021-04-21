namespace TelegramBot
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Telegram.Bot;
    using Telegram.Bot.Args;

    public class BotMessageLogic
    {
        private Messenger messanger;

        private Dictionary<long, Conversation> chatList;

        private ITelegramBotClient botClient;

        public BotMessageLogic(ITelegramBotClient botClient)
        {
            messanger = new Messenger(botClient);
            chatList = new Dictionary<long, Conversation>();
            this.botClient = botClient;
        }

        public async Task Response(MessageEventArgs e)
        {
            var Id = e.Message.Chat.Id;

            if (!chatList.ContainsKey(Id))
            {
                var newchat = new Conversation(e.Message.Chat);

                chatList.Add(Id, newchat);
            }

            var chat = chatList[Id];

            chat.AddMessage(e.Message);

            await SendMessage(chat);

        }

        private async Task SendMessage(Conversation chat)
        {
            await messanger.MakeAnswer(chat);
        }
    }
}
