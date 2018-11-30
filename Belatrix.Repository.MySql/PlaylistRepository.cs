using Belatrix.Models;
using Belatrix.Repository.Mysql;

namespace Belatrix.Repository.MySql
{
    public class PlaylistRepository : Repository<Playlist>, IPlaylistRepository
    {
        public PlaylistRepository(ChinookContext dbContex) : base(dbContex)
        {
        }
    }
}
