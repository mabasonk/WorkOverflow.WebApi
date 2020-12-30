using System.Threading.Tasks;
using WorkOverflow.WebApi.Application.DTOs;
using WorkOverflow.WebApi.Application.User;

namespace WorkOverflow.WebApi.IServices.Interfaces.User
{
    public interface IUserService
     {
         Task<Response> Register(UserViewModel user);
         Task<Response> Login(LoginViewModel login);

         Task<bool> UsernameExists(string username);
         Task<Response> UpdateUser(UserViewModel user);
         Task<Response> SuspendUser(string username);
         Task<UserViewModel> GetUserByUsername(string username);
     }
}
 