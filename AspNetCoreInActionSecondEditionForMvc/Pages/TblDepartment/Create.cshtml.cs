using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreInActionSecondEditionForMvc.tuseTheProgrammer.Models;
using AspNetCoreInActionSecondEditionForMvc.tuseTheProgrammer.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreInActionSecondEditionForMvc.Pages.TblDepartment
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _appDbContext;
        [BindProperty]
        public tblDepartment Department { get; set; }
        public CreateModel(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            _appDbContext.TblDepartments.Add(Department);
            _appDbContext.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
