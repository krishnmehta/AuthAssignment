using AuthAssignment.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AuthAssignment.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AuthAssignmentController : AbpControllerBase
{
    protected AuthAssignmentController()
    {
        LocalizationResource = typeof(AuthAssignmentResource);
    }
}
