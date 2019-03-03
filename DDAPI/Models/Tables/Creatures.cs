using System.ComponentModel.DataAnnotations.Schema;

namespace DDAPI.Models
{
    [Table("Creatures", Schema = "dbo")]
    public class Creatures
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Affiliation { get; set; }
        public int CurrentHp { get; set; }
        public int MaxHp { get; set; }
        public int ArmorClass { get; set; }
        public int? Strength { get; set; }
        public int? Dexterity { get; set; }
        public int? Constitution { get; set; }
        public int? Intelligence { get; set; }
        public int? Wisdom { get; set; }
        public int? Charisma { get; set; }
    }
}
