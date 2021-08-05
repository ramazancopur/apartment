using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Entity.Concrete
{
    public class Building
    {
        [Key, ForeignKey("User")]
        [Required(ErrorMessage = "Kullanıcı adını seçiniz")]
        public int BuildingID { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [StringLength(30)]
        public string City { get; set; }
        [StringLength(30)]
        public string County { get; set; }
        [StringLength(30)]
        public string Heating { get; set; }
        [StringLength(120)]
        public string address { get; set; }



        //User relationship  1-1
       
        public virtual User User { get; set; }
       

        //Expense relationship  1-N (1)
        public ICollection<Expense> Expenses { get; set; }

        //Flat relationship  1-N (1)
        public ICollection<Flat> Flats { get; set; }

    }
}
