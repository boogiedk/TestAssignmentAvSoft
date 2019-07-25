using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestAssignmentAvSoft.Infrastructure;
using TestAssignmentAvSoft.Models;
using TestAssignmentAvSoft.Providers;

namespace TestAssignmentAvSoft.Pages.Counter
{
    public class GetModel : PageModel
    {
        private readonly ICounterProvider _counterProvider;

        public GetModel(ICounterProvider counterProvider)
        {
            _counterProvider = counterProvider;
        }

        public IQueryable<CounterModel> CounterModel { get;set; }

        public async Task OnGetAsync()
        {
            CounterModel = await _counterProvider.GetCounter();
        }
    }
}
