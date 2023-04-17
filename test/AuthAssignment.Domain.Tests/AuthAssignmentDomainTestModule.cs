using AuthAssignment.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AuthAssignment;

[DependsOn(
    typeof(AuthAssignmentEntityFrameworkCoreTestModule)
    )]
public class AuthAssignmentDomainTestModule : AbpModule
{

}
