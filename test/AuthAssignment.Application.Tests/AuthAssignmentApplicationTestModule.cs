using Volo.Abp.Modularity;

namespace AuthAssignment;

[DependsOn(
    typeof(AuthAssignmentApplicationModule),
    typeof(AuthAssignmentDomainTestModule)
    )]
public class AuthAssignmentApplicationTestModule : AbpModule
{

}
