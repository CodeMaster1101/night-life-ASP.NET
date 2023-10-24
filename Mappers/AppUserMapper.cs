using night_life_sk.Models;
using night_life_sk.Dto.User;

namespace night_life_sk.Mappers
{
    internal static class AppUserMapper
    {

        private static AppUserDto ConvertToDTO(AppUser appUser)
        {
            return new AppUserDto(appUser.Username);
        }

        internal static async Task<HashSet<AppUserDto>> ConvertAllToDTOAsync(Task<HashSet<AppUser>> appUsers)
        {
            var users = await appUsers;
            return users.Select(user => ConvertToDTO(user)).ToHashSet();
        }
    }
}
