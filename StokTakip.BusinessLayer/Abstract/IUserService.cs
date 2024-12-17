using StokTakip.BusinessLayer.Dtos.User.Requests;
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
    public interface IUserService 
    {
        Task InsertAsync(InsertUserRequest dto);
        Task UpdateAsync(UpdateUserRequest dto);
        Task DeleteAsync(User user);
        Task<List<ListUserResponse>> GetAllAsync(Expression<Func<ListUserResponse, bool>>? predicate = null);
        Task<GetByIdUserResponse> GetByIDAsync(int id);
    }
}
