﻿namespace TelegramBot
{
    public class AskMeCommand : AbstractCommand, IChatTextCommand
    {
        public AskMeCommand()
        {
            CommandText = "/askme";
        }
        public string ReturnText()
        {
            return "how are you?";
        }
    }
}
