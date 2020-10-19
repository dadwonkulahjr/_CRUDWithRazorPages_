using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreInActionSecondEditionForMvc.tuseTheProgrammer.Models;
using AspNetCoreInActionSecondEditionForMvc.tuseTheProgrammer.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreInActionSecondEditionForMvc.Pages.TblGender
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _appDbContext;
        public IEnumerable<tblGender> Gender { get; set; }
        public IndexModel(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void OnGet()
        {
            Gender = _appDbContext.TblGenders.ToList();

        }
    }
}
