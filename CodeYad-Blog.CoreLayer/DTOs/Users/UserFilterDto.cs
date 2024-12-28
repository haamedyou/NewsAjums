using System.Collections.Generic;
using News_Ajums.CoreLayer.Utilities;

namespace News_Ajums.CoreLayer.DTOs.Users
{
    public class UserFilterDto:BasePagination
    {
        public List<UserDto> Users { get; set; }
    }

}