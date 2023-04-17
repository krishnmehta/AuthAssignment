using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Identity;

namespace AuthAssignment.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IdentityUserManager _userManager;

        public UserController(IdentityUserManager userManager)
        {
            _userManager = userManager;
        }
        [HttpGet("status-percentage")]
        public async Task<ActionResult<UserDto>> GetUserStatusPercentageAsync()
        {
            var users = await _userManager.Users.ToListAsync(); // Retrieve all registered users

            var onlineUsers = await _userManager.GetUsersInRoleAsync("Online"); // Retrieve online users

            var offlineUsers = users.Except(onlineUsers).ToList(); // Calculate offline users

            var onlinePercentage = (double)onlineUsers.Count / users.Count * 100;
            var offlinePercentage = (double)offlineUsers.Count / users.Count * 100;

            var result = new UserDto
            {
                OnlinePercentage = onlinePercentage,
                OfflinePercentage = offlinePercentage
            };
            return Ok(result);

        }
    }
}