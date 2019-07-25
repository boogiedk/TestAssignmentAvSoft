using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestAssignmentAvSoft.Infrastructure;
using TestAssignmentAvSoft.Models;
using TestAssignmentAvSoft.Providers;

namespace TestAssignmentAvSoft.Controllers
{
    public class CounterSpecialController : Controller
    {
        private readonly ICounterProvider _counterProvider;

        public CounterSpecialController(ICounterProvider counterProvider)
        {
            _counterProvider = counterProvider;
        }

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Запрос, возвращающий количество записей по столбцу id и записей, и счетчик значений больше единицы.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
           var counterSpecials =  _counterProvider.GetCounterSpecialModels();

           return View("Get", counterSpecials);
        }
    }
}