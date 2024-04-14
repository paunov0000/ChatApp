namespace ChatApp.Models
{
    public class ChatViewModel
    {
        public IList<MessageViewModel> Messages { get; set; } = null!;

        public MessageViewModel Message { get; set; } = null!;
    }
}
