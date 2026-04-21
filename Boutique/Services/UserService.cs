using Boutique.Models;

namespace Boutique.Services
{
    public class UserService
    {
        private readonly BoutiqueDbContext _db;

        public UserService(BoutiqueDbContext db)
        {
            _db = db; 
        }

        // ──  Affichage de tous les utilisateurs ─────────────────
        public List<Utilisateur> GetAll()
        {
            return _db.Utilisateurs.ToList();
        }

        public void Add(string nom, string email)
        {
            Utilisateur newUser = new Utilisateur { Nom = nom, Email = email };

            _db.Utilisateurs.Add(newUser);

            _db.SaveChanges();
        }
        public Utilisateur? FindById(int id)
        {
            return _db.Utilisateurs.Find(id);

        }

    }
}
