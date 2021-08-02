using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Entity.Concrete
{
    public class HostNote
    {
        [Key]
        public int HostNoteID { get; set; }
        [StringLength(120)]
        public string Note { get; set; }


        //User relationship  1-N (N)
        public int HostID { get; set; }
        public virtual Host Host { get; set; }
    }
}
