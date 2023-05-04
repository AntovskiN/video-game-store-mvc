using System.ComponentModel.DataAnnotations;

namespace Playtopia.Models
{
    public class Store
    {
        [Key]
        public int Id { get; set; }
        public string Location { get; set; }

        //relationships
        public List<Store_Game> Stores_Games { get; set; }
    }
}
