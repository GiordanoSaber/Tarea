using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using RazorPagesPizza.Models;
using RazorPagesPizza.Services;

using System.Collections.Generic;

namespace RazorPagesPizza.Pages
{
    public class SodaModel : PageModel
    {
        public List<Soda> sodas = new();
        [BindProperty]
        public Soda NewSoda { get; set; } = new();

        public void OnGet()
        {
            sodas = SodaService.GetAll();
        }

        public string DietText(Soda soda)
        {
            return soda.IsDiet ? "Diet" : "Regular";
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            SodaService.Add(NewSoda);
            return RedirectToAction("Get");
        }

        public IActionResult OnPostDelete(int id)
        {
            SodaService.Delete(id);
            return RedirectToAction("Get");
        }
    }
}

