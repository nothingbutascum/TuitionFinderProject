using FSDProject1.Data;
using Microsoft.AspNetCore.Identity;

namespace FSDProject1.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<FSDProject1User> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<FSDProject1User> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
