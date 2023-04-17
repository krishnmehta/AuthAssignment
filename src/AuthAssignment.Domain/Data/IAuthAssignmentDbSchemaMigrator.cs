using System.Threading.Tasks;

namespace AuthAssignment.Data;

public interface IAuthAssignmentDbSchemaMigrator
{
    Task MigrateAsync();
}
