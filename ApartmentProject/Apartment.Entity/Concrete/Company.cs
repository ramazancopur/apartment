using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Entity.Concrete
{
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }
        [StringLength(30)]
        public string Email { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [StringLength(30)]
        public string Phone { get; set; }
        public bool Status { get; set; }

        //Expense relationship 1-N (1)
        public ICollection<Expense> Expenses { get; set; }

        //User relationship  1-N (N)
        public int? UserID { get; set; }
        public virtual User User { get; set; }
    }
}
