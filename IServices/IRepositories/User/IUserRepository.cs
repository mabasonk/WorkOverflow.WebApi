using System.Threading.Tasks;
using WorkOverflow.WebApi.Application.DTOs;
using WorkOverflow.WebApi.Application.DTOs.User;

namespace WorkOverflow.WebApi.IServices.IRepositories.User
{
     public interface IUserRepository
     {
         Task<Response> LoginAsync(LoginDto userLogin);
         Task<Response> Register(UserDto user);
         Task<Response> UpdateUser(UserDto user);

         Task<UserDto> GetUserUserName(string userName);

         Task<Response> SuspendUser(string username);
     }
}
