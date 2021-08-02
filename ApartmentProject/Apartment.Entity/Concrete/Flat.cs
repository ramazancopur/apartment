using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Entity.Concrete
{
    public class Flat
    {
        [Key]
        public int FlatID { get; set; }
        [StringLength(1)]
        public string Block { get; set; }
        [StringLength(3)]
        public string No { get; set; }
        [StringLength(2)]
        public string Floor { get; set; }
        public int Area { get; set; }
        [StringLength(120)]
        public string Note { get; set; }

        //Building relationship  1-N (N)
        public int BuildingID { get; set; }
        public virtual Building Building { get; set; }

        //Condo fee relationship  1-N (1)
        public ICollection<CondooFee> CondooFees { get; set; }


        //Host relationship  1-1
        [Required]
        public virtual Host Host { get; set; }

        //Hirer relationship  1-1
        public virtual Hirer Hirer { get; set; }

    }
}
