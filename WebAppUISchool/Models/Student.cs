using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppUISchool.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int Sid { get; set; }

        public string SName { get; set; }
        public string Sclass { get; set; }


        


    }
}