using StokTakip.DataAccessLayer.Abstract;
using StokTakip.EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.DataAccessLayer.Repositories
{
    public class ProcessTypeRepository : GenericRepository<ProcessType>, IProcessTypeDal
    {
    }
}
