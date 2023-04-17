using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Polly;
using System.Threading.Tasks;

namespace AuthAssignment.Web
{
    public class OnlineUserHub : Hub
    {
        private readonly UserManager<IdentityUser> _userManager;

        public OnlineUserHub(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task RegisterConnectionAsync()
        {
            var user = await _userManager.GetUserAsync(Context.User);

            if (user != null)
            {
                // Add the user to the list of online users
                await _userManager.AddToRoleAsync(user, "Online");
            }
        }

        public async Task UnregisterConnectionAsync()
        {
            var user = await _userManager.GetUserAsync(Context.User);

            if (user != null)
            {
                // Remove the user from the list of online users
                await _userManager.RemoveFromRoleAsync(user, "Online");
            }
        }
    }

}
