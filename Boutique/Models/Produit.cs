using System;
using System.Collections.Generic;
using System.Text;

namespace Boutique.Models
{
    public class Produit
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public double Prix { get; set; }

        public ICollection<CommandeProduit> CommandeProduits { get; set; }
    }
}
