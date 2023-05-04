using Playtopia.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Playtopia.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public GameCategory GameCategory { get; set; }

        //relationships
        public List<Store_Game> Stores_Games { get; set; }

    }
}
