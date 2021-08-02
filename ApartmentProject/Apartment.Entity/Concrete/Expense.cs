using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Entity.Concrete
{
    public class Expense
    {
        [Key]
        public int ExpenseID { get; set; }
        public DateTime Date { get; set; }
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        public decimal Amount { get; set; }

        //Category relationship  1-N (N)
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        //Company relationship  1-N (N)
        public int CompanyID { get; set; }
        public virtual Company Company { get; set; }

        //Building relationship  1-N (N)
        public int BuildingID { get; set; }
        public virtual Building Building { get; set; }


    }
}
