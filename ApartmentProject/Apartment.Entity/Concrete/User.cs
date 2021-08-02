using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Entity.Concrete
{
    public class User
    {
        [Key]
        public int? UserID { get; set; }
        [StringLength(20)]
        public string UserName { get; set; }
        [StringLength(20)]
        public string Password { get; set; }
        [StringLength(20)]
        public string Email { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(20)]
        public string Surname { get; set; }

        //Building relationship  1-1
        [Required]
        public virtual Building Building { get; set; }


        //Category relationship  1-N (1)
        public ICollection<Category> Categories { get; set; }

        //Company relationship  1-N (1)
        public ICollection<Company> Companies { get; set; }
    }
}
