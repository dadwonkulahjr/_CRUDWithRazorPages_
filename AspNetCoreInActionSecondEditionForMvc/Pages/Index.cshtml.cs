using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CPC.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "My name is Dad S Wonkulah Jr \n" + " The current time check is " + DateTime.UtcNow;
        }
    }
}
