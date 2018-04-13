using System.Threading.Tasks;
using netcore_e2e_app.Core;

namespace netcore_e2e_app.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NetcoreE2eAppDbContext context;
        public UnitOfWork(NetcoreE2eAppDbContext context)
        {
            this.context = context;

        }
        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}