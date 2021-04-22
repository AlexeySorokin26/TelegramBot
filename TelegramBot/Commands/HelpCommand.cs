namespace TelegramBot
{
    public class HelpCommand : AbstractCommand, IChatTextCommand
    {
        private CommandHelper commandhelper;
        public HelpCommand()
        {
            commandhelper = new CommandHelper();
            CommandText = "/man";
        }

        public string ReturnText()
        {
            return commandhelper.Description;
        }
    }
}
