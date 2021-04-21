namespace TelegramBot.EnglishTrainer
{
    public enum AddingState
    {
        Russian, // idea is simple: we have 4 states: input russian version of word, then english, theme and finish job
        English,
        Theme,
        Finish
    }
}
