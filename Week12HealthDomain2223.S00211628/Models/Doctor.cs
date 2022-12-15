using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12HealthDomain2223.S00211628.Models
{
    [Table("Doctors")]
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DSS { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Specilization { get; set; }
        public string Email { get; set; }
    }
}
