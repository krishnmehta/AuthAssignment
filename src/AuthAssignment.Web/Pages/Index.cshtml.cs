using System;
using System.Threading.Tasks;
using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Identity;

namespace AuthAssignment.Web.Pages
{
    public class IndexModel : AuthAssignmentPageModel
    {
        protected IdentityUserManager UserManager { get; }

        private readonly IIdentityUserRepository _userRepository;

        public string PasswordlessLoginUrl { get; set; }

        public string Email { get; set; }

        public IndexModel(IdentityUserManager userManager, IIdentityUserRepository userRepository)
        {
            UserManager = userManager;
            _userRepository = userRepository;
        }

        public ActionResult OnGet()
        {
            if (!CurrentUser.IsAuthenticated)
            {
                return Redirect("/Account/Login");
            }
            // Set the email property to the email of the current user for 
            Email = CurrentUser.Email;

            return Page();
        }

        //added for passwordless authentication
        public async Task<IActionResult> OnPostGeneratePasswordlessTokenAsync()
        {
            var currentUserLogin = await UserManager.GetUserAsync(HttpContext.User);

            var token = await UserManager.GenerateUserTokenAsync(currentUserLogin, "PasswordlessLoginProvider",
            "passwordless-auth");

            PasswordlessLoginUrl = Url.Action("Login", "Passwordless",
                new { token = token, userId = currentUserLogin.Id.ToString() }, Request.Scheme);

            return Page();
        }
    }
}