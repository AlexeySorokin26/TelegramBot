namespace TelegramBot
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TelegramBot.EnglishTrainer;
    using Telegram.Bot;

    public class DictionaryCommand : AbstractCommand
    {
        private ITelegramBotClient botClient;

        public DictionaryCommand(ITelegramBotClient botClient)
        {
            CommandText = "/dictionary";

            this.botClient = botClient;
        }

        public async void ShowDictionary(Conversation chat)
        {
            //if(chat.dictionary.)
            foreach(KeyValuePair<string, Word> el in chat.dictionary)
            {
                await SendDictionary(el.Value, chat.GetId());
            }
        }

        private async Task SendDictionary(Word word, long chat)
        {
            string text = word.English + " = "+ word.Russian;
            await botClient.SendTextMessageAsync(chatId: chat, text: text);
        }
    }
}
