using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreInActionSecondEditionForMvc.tuseTheProgrammer.Models;
using AspNetCoreInActionSecondEditionForMvc.tuseTheProgrammer.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreInActionSecondEditionForMvc.Pages.Employees
{
    public class EditModel : PageModel
    {
        private readonly IPersonRepo _personRepo;
        [BindProperty]
        public tblPerson TblPerson { get; set; }
        public EditModel(IPersonRepo personRepo)
        {
            _personRepo = personRepo;
        }
        public IActionResult OnGet(int id)
        {
            TblPerson = _personRepo.GetPersonById(id);
            if (TblPerson != null)
            {
                return Page();
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                TblPerson = _personRepo.UpdatePerson(TblPerson);
                if(TblPerson != null)
                {
                    return RedirectToPage("Index");
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return Page();
            }
        }
    }
}
