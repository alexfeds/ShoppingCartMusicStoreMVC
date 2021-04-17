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
        public System.Data.Entity.DbSet<ShoppingCartMusicStore.Models.Genre> Genres { get; set; }

        public System.Data.Entity.DbSet<ShoppingCartMusicStore.Models.Artist> Artists { get; set; }

        public System.Data.Entity.DbSet<ShoppingCartMusicStore.Models.Cart> Carts { get; set; }

        public System.Data.Entity.DbSet<ShoppingCartMusicStore.Models.Order> Orders { get; set; }

        public System.Data.Entity.DbSet<ShoppingCartMusicStore.Models.OrderDetail> OrderDetails { get; set; }

    }
}