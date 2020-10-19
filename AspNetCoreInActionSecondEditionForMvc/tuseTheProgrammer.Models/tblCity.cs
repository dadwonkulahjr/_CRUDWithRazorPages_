using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreInActionSecondEditionForMvc.tuseTheProgrammer.Models
{
    public class tblCity
    {
        public tblCity()
        {
            TblPerson = new HashSet<tblPerson>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string Name { get; set; }
        public virtual ICollection<tblPerson> TblPerson { get; set; }
    }
}
