using System;
using System.ComponentModel.DataAnnotations;

namespace C43_G05_EF01.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public DateTime DOB { get; set; }
    }
}
