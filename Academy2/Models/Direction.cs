using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy2.Models
{
    public class Direction
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("direction_id", TypeName = "TINYINT")]
        public int direction_id { get; set; }
        public string direction_name { get; set; }
    }
}
