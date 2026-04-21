using Boutique.Models;
using Microsoft.EntityFrameworkCore;

namespace Boutique.Services
{
    public class CommandeService
    {
        private readonly BoutiqueDbContext _db;

        public CommandeService(BoutiqueDbContext db)
        {
            _db = db;
        }

        // Crée une commande pour un utilisateur avec ses lignes produit/quantité
        public Commande Create(int utilisateurId, List<(int ProduitId, int Quantite)> lignes)
        {
            if (lignes == null || lignes.Count == 0)
                throw new ArgumentException("La commande doit contenir au moins un produit.");

            var commande = new Commande
            {
                Date = DateTime.Now,
                UtilisateurId = utilisateurId,
                CommandeProduits = lignes
                    .Where(l => l.Quantite > 0)
                    .Select(l => new CommandeProduit
                    {
                        ProduitId = l.ProduitId,
                        Quantite = l.Quantite
                    })
                    .ToList()
            };

            _db.Commandes.Add(commande);
            _db.SaveChanges();

            return _db.Commandes
                .Include(c => c.Utilisateur)
                .Include(c => c.CommandeProduits)
                    .ThenInclude(cp => cp.Produit)
                .Single(c => c.Id == commande.Id);
        }

        public List<Commande> GetAll()
        {
            return _db.Commandes
                .Include(c => c.Utilisateur)
                .Include(c => c.CommandeProduits)
                    .ThenInclude(cp => cp.Produit)
                .OrderBy(c => c.Id)
                .ToList();
        }

        public List<Commande> GetByUtilisateurId(int utilisateurId)
        {
            return _db.Commandes
                .Include(c => c.Utilisateur)
                .Include(c => c.CommandeProduits)
                    .ThenInclude(cp => cp.Produit)
                .Where(c => c.UtilisateurId == utilisateurId)
                .OrderBy(c => c.Id)
                .ToList();
        }
    }
}