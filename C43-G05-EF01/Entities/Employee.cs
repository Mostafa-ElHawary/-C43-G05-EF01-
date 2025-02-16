using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_EF01.Entities
{

    // EF Core Support 4 Ways To Mapping Class In Databases [Table , View , Function]
    // 1- By Convention Way ---> Default behaviour
    // 2- Data Annoation [Set Of Attributes Used for Data Validation]


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
    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public string Adress { get; set; }

        public DateTime DateOfCreation { get; set; }



    }
}
