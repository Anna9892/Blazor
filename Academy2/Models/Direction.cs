using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Academy2.Models
{
    public class Direction
    {
        [Key]
        public byte direction_id { get; set; }
        public string direction_name { get; set; }
    }
}
