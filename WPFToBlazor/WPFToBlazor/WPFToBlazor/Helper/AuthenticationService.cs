using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace WPFToBlazor.Helper
{
    public class AuthenticationService
    {
        public async Task<string> CheckAuthenticationMethod(AuthenticationStateProvider authStateProvider)
        {
            var authState = await authStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;

            if (user.Identity is not null && user.Identity.IsAuthenticated)
            {
                return $"{user.Identity.Name} is authenticated.";
            }
            else
            {
                return "The user is NOT authenticated.";
            }
        }
    }
}
