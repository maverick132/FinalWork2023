using AnimalNursery.Models.Commands;

namespace AnimalNursery.Models.Request
{
    public class UpdateHomeFriendsRequest
    {
        public int HumanFriendsId { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public CommandsList Commands { get; set; }
        public string Type { get; set; }
    }
}
