using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Juan",
                    Email = "juan@test.com",
                    UserName = "juan@test.com",
                    Address = new Address
                    {
                        FirstName = "Juan",
                        LastName = "Cruz",
                        Street = "92 James Street",
                        City = "Etobicoke",
                        Province = "ON",
                        Zipcode = "M8W1L6"
                    }
                };

                await userManager.CreateAsync(user, "Password$1");
            }
        }
    }
}