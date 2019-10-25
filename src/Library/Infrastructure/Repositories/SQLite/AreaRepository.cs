using NetModular.Lib.Data.Abstractions;

namespace NetModular.Module.Common.Infrastructure.Repositories.SQLite
{
    public class AreaRepository : SqlServer.AreaRepository
    {
        public AreaRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
