namespace TelegramBot
{
    using Telegram.Bot.Types.ReplyMarkups;
    public interface IKeyBoardCommand
    {
        InlineKeyboardMarkup ReturnKeyBoard();

        void AddCallBack(Conversation chat);

        string InformationalMessage();
    }
}
