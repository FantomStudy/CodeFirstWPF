using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWPF.DataModel
{
    public class Posts
    {
        [Key]
        public int PostId { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Duty { get; set; }
    }
}
