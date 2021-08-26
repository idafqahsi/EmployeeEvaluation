using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeEvaluationAPI.Models
{
    public class Evaluation
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int EvaluationID { get; set; }

        [Required]
        [ForeignKey("done_by")]
        public Employee By { get; set; }

        [Required]
        [ForeignKey("done_for")]
        public Employee For { get; set; }

        [Required]
        [Column("value")]
        public int Value { get; set; }
    }
}
