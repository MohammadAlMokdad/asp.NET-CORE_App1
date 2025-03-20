using System.ComponentModel.DataAnnotations;

namespace WebApplication1
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
    }
}
