using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TestAssignmentAvSoft.Infrastructure;
using TestAssignmentAvSoft.Models;
using TestAssignmentAvSoft.Providers;

namespace TestAssignmentAvSoft.Pages.Counter
{
    public class InsertModel : PageModel
    {
        private readonly ICounterProvider _counterProvider;

        public InsertModel(ICounterProvider counterProvider)
        {
            _counterProvider = counterProvider;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CounterModel CounterModel { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _counterProvider.Insert(CounterModel);

            return RedirectToPage("./Index");
        }
    }
}