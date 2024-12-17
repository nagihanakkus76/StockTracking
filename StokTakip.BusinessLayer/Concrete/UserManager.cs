using AutoMapper;
using StokTakip.BusinessLayer.Abstract;
using StokTakip.BusinessLayer.Dtos.User.Requests;
using StokTakip.BusinessLayer.Dtos.User.Responses;
using StokTakip.DataAccessLayer.Abstract;
using StokTakip.EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        private readonly IMapper _mapper;
        public UserManager(IUserDal userDal, IMapper mapper)
        {
            _userDal = userDal;
            _mapper = mapper;
        }

        public async Task DeleteAsync(User user)
        {
           await _userDal.DeleteAsync(user);
        }

        public async Task<List<ListUserResponse>> GetAllAsync(Expression<Func<ListUserResponse, bool>>? predicate = null)
        {
            List<User> users = await _userDal.GetAllAsync();
            List<ListUserResponse> response = _mapper.Map<List<ListUserResponse>>(users);
            return response;
        }

        public async Task<GetByIdUserResponse> GetByIDAsync(int id)
        {
           User user = await _userDal.GetByIDAsync(id);
           GetByIdUserResponse response = _mapper.Map<GetByIdUserResponse>(user);
           return response;
        }

        public async Task InsertAsync(InsertUserRequest dto)
        {
            User user = _mapper.Map<User>(dto);
            using HMACSHA512 hmac = new HMACSHA512();

            user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(dto.Password));
            user.PasswordSalt = hmac.Key;


           await _userDal.InsertAsync(user);
        }

        public async Task UpdateAsync(UpdateUserRequest dto)
        {
            User user = _mapper.Map<User>(dto);
           await _userDal.UpdateAsync(user);    
        }

        public async Task Loggin(LogginDto dto)
        {
            User user = _mapper.Map<User>(dto);

          
        }
    }
}