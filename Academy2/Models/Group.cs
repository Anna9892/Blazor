using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy2.Models
{
    public class Group
    {
        public int group_id { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string group_name { get; set; }

        [Column("direction", TypeName = "TINYINT")]
        public int direction { get; set; }

        [Column("weekdays", TypeName = "TINYINT")]
        public int? learning_days { get; set; }

        [Column("start_time", TypeName = "TIME(0)")]
        public TimeOnly? start_time { get; set; }

        [Column("start_date", TypeName = "DATE")]
        public DateOnly? start_date { get; set; }
    }
}
