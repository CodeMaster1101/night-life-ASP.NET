using night_life_sk.Models;
using night_life_sk.Dto.User;

namespace night_life_sk.Mappers
{
    public class AppUserMapper
    {

        private static AppUserDto ConvertToDTO(AppUser appUser)
        {
            return new AppUserDto(appUser.Username);
        }

        public HashSet<AppUserDto> ConvertAllToDTO(HashSet<AppUser> appUsers)
        {
            return appUsers.Select(user => ConvertToDTO(user)).ToHashSet();
        }
    }
}
