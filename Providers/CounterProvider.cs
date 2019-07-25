using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestAssignmentAvSoft.Infrastructure;
using TestAssignmentAvSoft.Models;

namespace TestAssignmentAvSoft.Providers
{
    public class CounterProvider : ICounterProvider
    {
        private readonly Context _context;

        public CounterProvider(Context context)
        {
            _context = context;
        }

        public async Task<IQueryable<CounterModel>> GetCounter()
        {
            return _context.Counters.AsQueryable();
        }

        public async Task Insert(CounterModel counterModel)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    _context.Counters.Add(counterModel);
                    await _context.SaveChangesAsync();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public List<CounterSpecialModel> GetCounterSpecialModels()
        {
            var counterSpecials = new List<CounterSpecialModel>();

            _context.Counters
                .GroupBy(g => g.Id)
                .Select(s => s.First()).ToList()
                .ForEach(f => counterSpecials.Add(new CounterSpecialModel
                {
                    Id = f.Id,
                    Count = _context.Counters.Count(c => c.Id == f.Id),
                    CountMoreThenOne = _context.Counters.Count(c => c.Value > 1 && c.Id == f.Id)
                }));

            return counterSpecials;
        }

    }
}
