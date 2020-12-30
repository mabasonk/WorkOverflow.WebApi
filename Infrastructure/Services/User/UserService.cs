using System.Net.NetworkInformation;
using System.Threading.Tasks;
using WorkOverflow.WebApi.Application.DTOs;
using WorkOverflow.WebApi.Application.DTOs.User;
using WorkOverflow.WebApi.Application.User;
using WorkOverflow.WebApi.IServices.Interfaces.User;
using WorkOverflow.WebApi.IServices.IRepositories.User;

namespace WorkOverflow.WebApi.Infrastructure.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Response> Register(UserViewModel user)
        {
            //map from vm to dto
            var userDto = new UserDto();
            return await _userRepository.Register(userDto);
        }

        public async Task<Response> Login(LoginViewModel login)
        {
            var loginDto = new LoginDto();
            return await _userRepository.LoginAsync(loginDto);
        }

        public async Task<bool> UsernameExists(string username)
        {
            var user = await _userRepository.GetUserUserName(username);
            return user != null;
        }

        public async Task<Response> UpdateUser(UserViewModel user)
        {
            var userDto = new UserDto();//map 
            var userToUpdate = await _userRepository.GetUserUserName(user.UserName);
            if (userToUpdate == null)
            {
                return new Response {Message = "User not Found"};
            }

            return await _userRepository.UpdateUser(userDto);
        }

        public async Task<Response> SuspendUser(string username)
        {
            return await _userRepository.SuspendUser(username);
        }

        public async Task<UserViewModel> GetUserByUsername(string username)
        {
            var user = await _userRepository.GetUserUserName(username);

            //map from dto to vm

            return new UserViewModel();
        }
    }
}
