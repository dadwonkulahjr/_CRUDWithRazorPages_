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
    public class DeleteModel : PageModel
    {
        private readonly IPersonRepo _personRepo;
        [BindProperty]
        public tblPerson TblPerson { get; set; }
        public DeleteModel(IPersonRepo personRepo)
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
                return NotFound();
            }
        }

        public IActionResult OnPost()
        {
            TblPerson = _personRepo.DeletePerson(TblPerson.PersonId);
            if(TblPerson != null)
            {
                return RedirectToPage("Index");
            }
            else
            {
                return NotFound();
            }
        }
    }
}
