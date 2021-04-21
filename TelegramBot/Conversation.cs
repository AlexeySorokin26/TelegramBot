namespace TelegramBot
{
    using Telegram.Bot.Types;
    using System.Collections.Generic;
    class Conversation
    {
        /// <summary>
        /// to deal with chat
        /// </summary>
        private Chat telegramChat;
        
        /// <summary>
        /// to store messages
        /// </summary>
        private List<Message> telegramMessages;

        public Conversation(Chat chat)
        {
            telegramChat = new Chat();
            telegramMessages = new List<Message>();
        }

        public void AddMessage(Message message)
        {
            telegramMessages.Add(message);
        }

        public List<string> GetTextMessages()
        {
            var textMessages = new List<string>();

            foreach (var message in telegramMessages)
            {
                if (message.Text != null)
                {
                    textMessages.Add(message.Text);
                }
            }

            return textMessages;
        }

        public long GetId() => telegramChat.Id;
    }
}
