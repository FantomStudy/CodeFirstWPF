using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWPF.DataModel
{
    public class Employees
    {
        [Required]
        [Key]
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        [MaxLength(11)]
        public string Passport { get; set; }
        [MaxLength(15)]
        public string Phone { get; set; }
        [ForeignKey("Posts")]
        public int PostId { get; set; }   
        public Posts Posts { get; set; }
    }
}
