using AuthAssignment.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AuthAssignment.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AuthAssignmentEntityFrameworkCoreModule),
    typeof(AuthAssignmentApplicationContractsModule)
    )]
public class AuthAssignmentDbMigratorModule : AbpModule
{

}
