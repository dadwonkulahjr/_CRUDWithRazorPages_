using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreInActionSecondEditionForMvc.tuseTheProgrammer.Models
{
    public class tblPerson
    {
        [Key]
        public int PersonId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [Column(name:"GenderId", TypeName ="int")]
        public tblGender Gender { get; set; }
        [Required]
        [Column(name: "CityId", TypeName = "int")]
        public tblCity City { get; set; }
        [Required]
        [Column(name: "DepartmentId", TypeName = "int")]
        public tblDepartment Department { get; set; }
      

    }
}
