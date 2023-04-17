using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AuthAssignment.Web;

[Dependency(ReplaceServices = true)]
public class AuthAssignmentBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AuthAssignment";
}
