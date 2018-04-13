using System.Threading.Tasks;

namespace netcore_e2e_app.Core
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}