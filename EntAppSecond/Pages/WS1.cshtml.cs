using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Week2WS.Pages
{
    public class WS1Model : PageModel
    {
        public string Message;

        public string[] MyTestArray { get; set; }
        = { "England", "Ireland", "Scotland", "Wales" };

        [BindProperty]
        public string FirstName { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()  //make sure the input value relates to Number1 on the cshtml page
        {
            Message =
                $"Hello {FirstName}";
        }

    }
}