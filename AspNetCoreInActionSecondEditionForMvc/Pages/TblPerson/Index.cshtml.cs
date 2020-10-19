using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreInActionSecondEditionForMvc.tuseTheProgrammer.Models;
using AspNetCoreInActionSecondEditionForMvc.tuseTheProgrammer.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreInActionSecondEditionForMvc.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _appDbContext;
        public IEnumerable<tblPerson> TblPerson { get; set; }
        public IndexModel(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void OnGet()
        {
            TblPerson = _appDbContext.TblPersons
                       .Include(p => p.Department)
                       .Include(p => p.Gender)
                       .Include(p => p.City)
                       .ToList();
        }
    }
}
