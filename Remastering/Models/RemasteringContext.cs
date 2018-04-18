using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Remastering.Models
{
    public class RemasteringContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Band> Bands { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Purchased> Purchaseds { get; set; }
        public DbSet<Song> Songs { get; set; }

        public RemasteringContext(DbContextOptions<RemasteringContext> options)
            : base(options)
        {
        }
    }
}
