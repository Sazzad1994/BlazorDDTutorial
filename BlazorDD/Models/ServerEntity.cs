namespace BlazorDD.Models
{
    public class ServerEntity
    {
        public ServerEntity()
        {
                Random random = new Random();
                int randomNumber= random.Next(0,2);
                 IsOnline = randomNumber == 0 ? false : true;

        }

        public int ServerId { get; set; }
        public bool IsOnline { get; set; }
        public string? ServerName { get; set; }
        public string? LocatedCity { get; set; }
    }
}
