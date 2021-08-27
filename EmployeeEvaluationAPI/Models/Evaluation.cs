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
        [Column("done_by")]
        public int ByEmployeeID { get; set; }
        [ForeignKey("ByEmployeeID")]
        public virtual Employee ByEmployee { get; set; }

        [Required]
        [Column("done_for")]
        public int ForEmployeeID { get; set; }
        [ForeignKey("ForEmployeeID")]
        public virtual Employee ForEmployee { get; set; }

        [Required]
        [Column("value")]
        public int Value { get; set; }
    }
}
