using System;
using System.ComponentModel.DataAnnotations;

namespace C43_G05_EF01.Entities
{
    public class Enrollment
    {
       
        public int Id { get; set; }

      
        public int StudentId { get; set; }

       
        public int CourseId { get; set; }

       
        public DateTime Date { get; set; }
    }
}
