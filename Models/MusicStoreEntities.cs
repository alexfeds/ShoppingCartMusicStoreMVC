using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShoppingCartMusicStore.Models
{
    public class MusicStoreEntities : DbContext
    {
        public System.Data.Entity.DbSet<ShoppingCartMusicStore.Models.Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public System.Data.Entity.DbSet<ShoppingCartMusicStore.Models.Artist> Artists { get; set; }
    }
}