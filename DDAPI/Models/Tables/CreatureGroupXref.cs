using System.ComponentModel.DataAnnotations.Schema;

namespace DDAPI.Models
{
    [Table("CreatureGroupXref", Schema = "dbo")]
    public class CreatureGroupXref
    {
        public int Id { get; set; }
        public int CreatureId { get; set; }
        public int GroupId { get; set; }
    }
}
