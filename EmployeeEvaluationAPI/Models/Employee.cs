using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeEvaluationAPI.Models
{
    [Table("Employee")]
    public class Employee
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(50)]
        [Column("name")]
        public String Name { get; set; }

        [Required]
        [Column("age")]
        public int Age { get; set; }

        [Required]
        [Column("rating")]
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double Rating{get; set; }


    }
}
