using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreInActionSecondEditionForMvc.tuseTheProgrammer.Models;
using AspNetCoreInActionSecondEditionForMvc.tuseTheProgrammer.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspNetCoreInActionSecondEditionForMvc.Pages.Employees
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _appDbContext;
        [BindProperty]
        public tblPerson TblPerson { get; set; }
        public CreateModel(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult OnGet()
        {
            ViewData["TblDepartmentId"] = new SelectList(_appDbContext.TblDepartments, "Id", "Name");
            ViewData["TblGenderId"] = new SelectList(_appDbContext.TblGenders, "Id", "Name");
            ViewData["TblCityId"] = new SelectList(_appDbContext.TblCities, "Id", "Name");
            return Page();
        }
        public IActionResult OnPost()
        {
            _appDbContext.TblPersons.Add(TblPerson);
            _appDbContext.SaveChanges();
            return RedirectToPage("Index");
        }
       
    }
}
