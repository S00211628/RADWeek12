using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12HealthDomain2223.S00211628.Models
{
    [Table("Patients")]
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Insurance { get; set; }

        [ForeignKey("DoctorDSS")]
        public int DSS { get; set; }
        public virtual Doctor DoctorDSS { get; set; }
        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        public DateTime DateAdmitted { get; set; }
        [Column(TypeName = "date")]
        [DataType(DataType.Date)]
        public DateTime DateCheckedOut { get; set; }


    }
}
