using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace Academy2.Models
{
    public class Discipline
    {
        [Key]
        [Column(TypeName = "SMALLINT")]

        public int discipline_id { get; set; }

        [Required]
        [StringLength(150)]
        [Column(TypeName = "NVARCHAR(150)")]

        public string discipline_name { get; set; }

        [Required]
        [Column(TypeName = "TINYINT")]

        public int number_of_lessons { get; set; }  


        //Navigation properties:
        public ICollection<Teacher> Teacher { get; set; }

    }
}
