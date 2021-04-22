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
                    " Create your own library and train!" +
                    " ps very easy to ruin it... be careful... please..." + 
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
