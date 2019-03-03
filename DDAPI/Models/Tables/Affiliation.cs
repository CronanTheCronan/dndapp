using System.ComponentModel.DataAnnotations.Schema;

namespace DDAPI.Models
{
    [Table("Affiliation", Schema = "dbo")]
    public class Affiliation
    {
        public int Id { get; set; }
        public string AffiliationType { get; set; }
    }
}
