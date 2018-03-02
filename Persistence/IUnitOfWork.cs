using System.Threading.Tasks;

namespace netcore_e2e_app.Persistence
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}