using System.ComponentModel.DataAnnotations.Schema;

namespace DDAPI.Models
{
    [Table("Groups", Schema = "dbo")]
    public class Groups
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
