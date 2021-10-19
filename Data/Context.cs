using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ApiPneuStoreG03.Model;

public class Context : IdentityDbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<CartItem> CartItem { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<Pedido> Pedido { get; set; }

        public DbSet<Category> Category { get; set; }
    }
