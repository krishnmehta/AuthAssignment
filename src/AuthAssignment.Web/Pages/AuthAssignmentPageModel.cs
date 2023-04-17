using AuthAssignment.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AuthAssignment.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class AuthAssignmentPageModel : AbpPageModel
{
    protected AuthAssignmentPageModel()
    {
        LocalizationResourceType = typeof(AuthAssignmentResource);
    }
}
