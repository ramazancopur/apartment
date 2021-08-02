using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Entity.Concrete
{
    public class CondooFee
    {
        [Key]
        public int CondoFeeID { get; set; }
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        //Flat relationship  1-N (N)
        public int FlatID { get; set; }
        public virtual Flat Flat { get; set; }

        //Receipt relationship  1-1
        [Required]
        public virtual Receipt Receipt { get; set; }

    }
}
