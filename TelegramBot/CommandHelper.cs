namespace TelegramBot
{
    public class CommandHelper
    {
        public string Description 
        { 
            get
            {
                return
                    "  Welcome to the TrainingBot2!" +
                    //"---------------------------------------------------------------------------/n" +
                    " Type /man to see how to use it." +
                    //"---------------------------------------------------------------------------/n" +
                    " Type /addword to add a word into your dictionary." +
                    //"---------------------------------------------------------------------------/n" +
                    " Type /deleteword to delete a word from your dictionary." +
                    //"---------------------------------------------------------------------------/n" +
                    " Type /dictionary to show your words from your dictionary." +
                    //"---------------------------------------------------------------------------/n" +
                    " Type /training to train your words from your dictionary (to quit " +
                    "type /stop).";
                    //"---------------------------------------------------------------------------/n";
            } 
        }
    }
}
