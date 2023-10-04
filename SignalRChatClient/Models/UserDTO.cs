namespace SignalRChatClient.Models
{
    public class UserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        public string ImageUrl { get; set; }
    }
}
