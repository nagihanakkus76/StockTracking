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
    public class ProcessTypeManager : IProcessTypeService
    {

        private readonly IProcessTypeDal _processTypeDal;
        public ProcessTypeManager(IProcessTypeDal processTypeDal)
        {
            _processTypeDal = processTypeDal;
        }

        public async Task DeleteAsync(ProcessType processType)
        {
            await _processTypeDal.DeleteAsync(processType);
        }

        public async Task<List<ProcessType>> GetAllAsync(Expression<Func<ProcessType, bool>>? predicate = null)
        {
            return await _processTypeDal.GetAllAsync();
        }

        public async Task<ProcessType> GetByIDAsync(int id)
        {
            return await _processTypeDal.GetByIDAsync(id);
        }

        public async Task InsertAsync(ProcessType processType)
        {
            await _processTypeDal.InsertAsync(processType);
        }

        public async Task UpdateAsync(ProcessType processType)
        {
            await _processTypeDal.UpdateAsync(processType);
        }
    }
}
