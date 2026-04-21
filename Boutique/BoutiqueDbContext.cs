using Boutique.Models;
using Microsoft.EntityFrameworkCore;

namespace Boutique
{
    class BoutiqueDbContext : DbContext
    {
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<CommandeProduit> CommandeProduits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection_string = "Data Source=DESKTOP-LDNM8KV\\SQLEXPRESS;Initial Catalog=shop;Integrated Security=True;Encrypt=False";
            string db_name = "shop";
            optionsBuilder.UseSqlServer($"{connection_string}; Database={db_name}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CommandeProduit>().HasKey(cp => new {cp.CommandeId,cp.ProduitId});

            modelBuilder.Entity<CommandeProduit>()
            .HasOne(cp => cp.Commande)
            .WithMany(c => c.CommandeProduits)
            .HasForeignKey(cp => cp.CommandeId);

            modelBuilder.Entity<CommandeProduit>()
                .HasOne(cp => cp.Produit)
                .WithMany(p => p.CommandeProduits)
                .HasForeignKey(cp => cp.ProduitId);
        }
    }
}
