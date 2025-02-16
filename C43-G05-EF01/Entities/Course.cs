using System.ComponentModel.DataAnnotations;

namespace C43_G05_EF01.Entities
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        
        public int Credits { get; set; }
    }
}
