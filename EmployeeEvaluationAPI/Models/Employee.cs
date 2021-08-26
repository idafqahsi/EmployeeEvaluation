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
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int EmployeeID { get; set; }

        [StringLength(50)]
        [Required]
        [Column("name")]
        public String Name { get; set; }

        [Required]
        [Column("age")]
        public int Age { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("rating")]
        public double Rating { get; set; }

    }
}
