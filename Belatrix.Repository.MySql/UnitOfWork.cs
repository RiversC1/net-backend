﻿using Belatrix.Models;

namespace Belatrix.Repository.Mysql
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ChinookContext dbContext)
        {
            Genres = new GenreRepository(dbContext);
            Artists = new ArtistRepository(dbContext);
            Playlists = new MySql.PlaylistRepository(dbContext);
        }
       // public IGenreRepository Genres { get; }

       // public IArtistRepository Artists { get; }

       public IRepository<Artist> Artists { get; }

       public IRepository<Genre> Genres { get; }

       public IRepository<Playlist> Playlists { get; }
    }
}
