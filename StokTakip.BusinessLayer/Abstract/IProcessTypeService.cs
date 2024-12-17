using StokTakip.EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BusinessLayer.Abstract
{
    public interface IProcessTypeService
    {
        Task InsertAsync(ProcessType processType);
        Task UpdateAsync(ProcessType processType);
        Task DeleteAsync(ProcessType processType);
        Task<List<ProcessType>> GetAllAsync(Expression<Func<ProcessType, bool>>? predicate = null);
        Task<ProcessType> GetByIDAsync(int id);
    }
}