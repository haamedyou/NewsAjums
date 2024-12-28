using News_Ajums.DataLayer.Entities;

namespace News_Ajums.CoreLayer.DTOs.Users
{
    public class EditUserDto
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public UserRole Role { get; set; }

    }
}