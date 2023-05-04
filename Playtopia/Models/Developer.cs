using System.ComponentModel.DataAnnotations;

namespace Playtopia.Models
{
    public class Developer
    {
        [Key]
        public int Id { get; set; }
        public string LogoURL { get; set; }
        public string Name { get; set;}
        public string Description { get; set;}

        //relationships
        public List<Game> Games { get; set;}
    }
}
