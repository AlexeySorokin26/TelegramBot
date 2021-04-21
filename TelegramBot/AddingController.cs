namespace TelegramBot
{
    using TelegramBot.EnglishTrainer;
    using System.Collections.Generic;

    public class AddingController
    {
        private Dictionary<long, AddingState> ChatAdding;

        public AddingController()
        {
            ChatAdding = new Dictionary<long, AddingState>();
        }

        // first state to add russian version of word
        public void AddFirstState(Conversation chat)
        {
            ChatAdding.Add(chat.GetId(), AddingState.Russian);
        }
        // all others states 
        public void NextStage(string message, Conversation chat)
        {
            var currentstate = ChatAdding[chat.GetId()];
            ChatAdding[chat.GetId()] = currentstate + 1;

            if (ChatAdding[chat.GetId()] == AddingState.Finish)
            {
                chat.IsAddingInProcess = false;
                ChatAdding.Remove(chat.GetId());
            }
        }

        public AddingState GetState(Conversation chat)
        {
            return ChatAdding[chat.GetId()];
        }

    }
}