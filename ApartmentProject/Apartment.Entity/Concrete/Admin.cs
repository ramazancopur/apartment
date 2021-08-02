using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Entity.Concrete
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        [StringLength(20)]
        public string AdminName { get; set; }
        [StringLength(20)]
        public string Password { get; set; }
        public int Role { get; set; }
        
    }
    
}
