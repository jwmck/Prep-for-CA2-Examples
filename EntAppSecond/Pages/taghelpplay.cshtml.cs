using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Week2WS.Pages
{
    public class taghelpplayModel : PageModel
    {
        public string Message;

        [BindProperty]
        public int Number1 { get; set; }

        [BindProperty]
        public int? Number2 { get; set; }

        [BindProperty]
        public double Double { get; set; }

        [BindProperty]
        public double? Double2 { get; set; }

        [BindProperty]
        public decimal Decimal { get; set; }

        [BindProperty]
        public decimal? Decimal2 { get; set; }

        [BindProperty]
        public float Float { get; set; }

        [BindProperty]
        public float? Float2 { get; set; }

        [BindProperty]
        public string String { get; set; }  //string is non-nullable

        [BindProperty]
        public DateTime? DateTime { get; set; }

        [BindProperty]
        public DateTime? DateTime2 { get; set; }

        [BindProperty]
        public bool isContactAllowed { get; set; }

        [BindProperty]
        public string Season { get; set; }

        public void OnGet()
        {
            Message = "Choose a button";
        }

        public void OnPost()
        {
            Message = $"Your favourite season is {Season}";
        }
    }
}