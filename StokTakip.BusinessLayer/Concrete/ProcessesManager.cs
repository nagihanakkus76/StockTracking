using StokTakip.BusinessLayer.Abstract;
using StokTakip.DataAccessLayer.Abstract;
using StokTakip.EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BusinessLayer.Concrete
{
    public class ProcessesManager : IProcessesService
    {
        private readonly IProcessesDal _processesDal;

        public ProcessesManager(IProcessesDal processesDal)
        {
            _processesDal = processesDal;
        }

        public async Task DeleteAsync(Processes processes)
        {
           await _processesDal.DeleteAsync(processes);
        }

        public async Task<List<Processes>> GetAllAsync(Expression<Func<Processes, bool>>? predicate = null)
        {
            return await _processesDal.GetAllAsync();
        }

        public async Task<Processes> GetByIDAsync(int id)
        {
            return await _processesDal.GetByIDAsync(id); 
        }

        public async Task InsertAsync(Processes processes)
        {
            await _processesDal.InsertAsync(processes);
        }

        public async Task UpdateAsync(Processes processes)
        {
            await _processesDal.UpdateAsync(processes);
        }
    }
}