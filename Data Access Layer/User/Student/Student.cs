using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Student
{
    [Table("Student")]
    public class StudentClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "int")]
        public int Roll_No { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string StudentName { get; set; }
        [Column(TypeName = "varchar(50)")]

        public string Address { get; set; }
        [Column(TypeName = "varchar(50)")]

        public string Father_Name { get; set; }

    }
}