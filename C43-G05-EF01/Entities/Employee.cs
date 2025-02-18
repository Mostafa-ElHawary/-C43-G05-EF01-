using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_EF01.Entities
{

    //internal class Employee
    //{

    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public double Salary { get; set; } without ? it's mean requierd
    //    public? string Adress { get; set; } // ? it's mean Optional 

    //    public DateTime DateOfCreation { get; set; }



    //}

    // 2- Data Annoation 
    //internal class Employee
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int Id { get; set; }

    //    [Required]
    //    [MaxLength(50)]
    //    public string Name { get; set; }

    //    [Range(18, 65)]
    //    public int Age { get; set; }

    //    [Column(TypeName = "decimal(18,2)")]
    //    public decimal Salary { get; set; }

    //    [MaxLength(100)]
    //    public string Address
    //    {
    //        get; set;
    //    }
    //}

    // 3- Fluent API

    class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public decimal Salary { get; set; }

        public string Address { get; set; }
    }
}
