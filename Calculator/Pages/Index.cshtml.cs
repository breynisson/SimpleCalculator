using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Calculator.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public float firstNumber { get; set; }
        [BindProperty]
        public float secondNumber { get; set; }
        [BindProperty]
        public float Result { get; set; }

        
        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            Result = firstNumber + secondNumber;
        }
    }
}
