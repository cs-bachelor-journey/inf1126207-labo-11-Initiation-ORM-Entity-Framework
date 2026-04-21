using System;
using System.Collections.Generic;
using System.Text;

namespace Boutique.Models
{
    public class CommandeProduit
    {
        public int CommandeId { get; set; }
        public Commande Commande { get; set; }

        public int ProduitId { get; set; }
        public Produit Produit { get; set; }

        public int Quantite { get; set; }
    }
}
