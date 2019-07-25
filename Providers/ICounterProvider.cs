using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAssignmentAvSoft.Models;

namespace TestAssignmentAvSoft.Providers
{
    public interface ICounterProvider
    {

        /// <summary>
        /// Запрос данных без преобразований из таблицы 1 в IQueryable.
        /// </summary>
        /// <returns></returns>
        Task<IQueryable<CounterModel>> GetCounter();

        /// <summary>
        /// Добавление новой записи в таблицу 1.
        /// </summary>
        /// <param name="counterModel"></param>
        /// <returns></returns>
        Task Insert(CounterModel counterModel);

        /// <summary>
        /// Запрос, возвращающий количество записей по столбцу id и записей, и
        /// счетчик значений больше единицы
        /// </summary>
        /// <returns></returns>
        List<CounterSpecialModel> GetCounterSpecialModels();
    }
}
