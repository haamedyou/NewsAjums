using News_Ajums.CoreLayer.DTOs.Users;
using News_Ajums.CoreLayer.Utilities;
using News_Ajums.DataLayer.Entities;

namespace News_Ajums.CoreLayer.Services.Users
{
    public interface IUserService
    {
        OperationResult EditUser(EditUserDto command);
        OperationResult RegisterUser(UserRegisterDto registerDto);
        UserDto LoginUser(LoginUserDto loginDto);
        UserDto GetUserById(int userId);
        UserFilterDto GetUsersByFilter(int pageId, int take);
    }
}