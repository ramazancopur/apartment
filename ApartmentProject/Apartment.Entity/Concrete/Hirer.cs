using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Entity.Concrete
{
    public class Hirer
    {
        [Key, ForeignKey("Flat")]
        public int HirerID { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [StringLength(30)]
        public string Surname { get; set; }
        [StringLength(30)]
        public string Phone { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        

        //Flat relationship  1-1
        [Required]
        public virtual Flat Flat { get; set; }


        //Receipt relationship 1-N (1)
        public ICollection<Receipt> Receipts { get; set; }




    }
}
