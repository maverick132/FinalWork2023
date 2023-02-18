using System.Data.SQLite;
using AnimalNursery.Models.Commands;

namespace AnimalNursery.Models.Animals
{
    public class HomeFriend
    {
        public int HumanFriendsId { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public CommandsList Commands { get; set; }
        public string Type { get; set; }

        public HomeFriend() {
            Name= string.Empty;
            Commands = new CommandsList();
        }
       
        public void Voise()
        {
        }
        public void Sleep()
        {
        }
        public void Eat()
        {
        }
    }
}
