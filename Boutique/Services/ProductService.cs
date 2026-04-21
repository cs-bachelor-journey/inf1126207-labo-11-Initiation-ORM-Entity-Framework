using Boutique.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boutique.Services
{
    public class ProductService
    {
        private readonly BoutiqueDbContext _db;

        public ProductService(BoutiqueDbContext db)
        {
            _db = db; 
        }


        public List<Produit> GetAll()
        {
            return _db.Produits.ToList();
        }

        public void Add(string nom, double prix)
        {
            Produit newProduct = new Produit { Nom = nom, Prix = prix };

            _db.Produits.Add(newProduct);

            _db.SaveChanges();
        }

        public Produit? FindById(int id)
        {
            return _db.Produits.Find(id);

        }

        // Filtre prix > 50 $
        public List<Produit>  GreaterPrice()
        {
            return _db.Produits.Where(p => p.Prix > 50).OrderBy(p => p.Prix).ToList();
        }
    }
}
