using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Entity.Concrete
{
    public class Receipt
    {
        [Key, ForeignKey("CondooFee")]
        public int ReceiptID { get; set; }
        public DateTime Date { get; set; }
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        public decimal Amount { get; set; }


        //CondooFee relationship  1-1
        [Required]
        public virtual CondooFee CondooFee { get; set; }


        //Host relationship  1-N (N)
        public int? HirerID { get; set; }
        public virtual Hirer Hirer { get; set; }

        //Hirer relationship  1-N (N)
        public int? HostID { get; set; }
        public virtual Host Host { get; set; }
    }
}
