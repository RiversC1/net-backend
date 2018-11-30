using Belatrix.Models;

namespace Belatrix.Repository
{
    public interface IUnitOfWork
    {
      
        IRepository<Artist> Artists { get; }

        IRepository<Genre> Genres { get; }
    }
}
