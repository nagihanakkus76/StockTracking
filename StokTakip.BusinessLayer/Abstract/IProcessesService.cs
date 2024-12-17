using StokTakip.BusinessLayer.Dtos.User.Responses;
using StokTakip.EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BusinessLayer.Abstract
{
    public interface IProcessesService
    {
        Task InsertAsync(Processes processes);
        Task UpdateAsync(Processes processes);
        Task DeleteAsync(Processes processes);
        Task<List<Processes>> GetAllAsync(Expression<Func<Processes, bool>>? predicate = null);
        Task<Processes> GetByIDAsync(int id);
    }
}
