using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppUISchool.Models
{
    [Table("Class")]
    public class Class
    {
        [Key]
        public int CId { get; set; }
        public string CName { get; set; }
        public string CTeacher { get; set; }
    }
}