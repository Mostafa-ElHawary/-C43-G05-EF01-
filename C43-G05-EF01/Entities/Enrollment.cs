using System;
using System.ComponentModel.DataAnnotations;

namespace C43_G05_EF01.Entities
{
    public class Enrollment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int StudentId { get; set; }

        [Required]
        public int CourseId { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
