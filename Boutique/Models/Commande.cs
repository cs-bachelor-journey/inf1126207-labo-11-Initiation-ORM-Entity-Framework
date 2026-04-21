using System;
using System.Collections.Generic;
using System.Text;

namespace Boutique.Models
{
    public class Commande
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }


        public int UtilisateurId { get; set;  }
        public Utilisateur Utilisateur { get; set; }

        public ICollection<CommandeProduit> CommandeProduits { get; set; }
    }
}
