
using Boutique;
using Boutique.Services;

var dbContext = new BoutiqueDbContext();
var userServices = new UserService(dbContext);
var productServices = new ProductService(dbContext);

// Adding users to the db 
(string Nom, string Email)[] users =
[
    ("Alice Tremblay", "alice.tremblay@boutique.test"),
    ("Benjamin Gagnon", "benjamin.gagnon@boutique.test"),
    ("Camille Roy", "camille.roy@boutique.test"),
    ("David Bouchard", "david.bouchard@boutique.test"),
    ("Emma Fortin", "emma.fortin@boutique.test"),
    ("Félix Côté", "felix.cote@boutique.test"),
    ("Gabrielle Pelletier", "gabrielle.pelletier@boutique.test"),
    ("Hugo Lavoie", "hugo.lavoie@boutique.test"),
    ("Isabelle Morin", "isabelle.morin@boutique.test"),
    ("Julien Gauthier", "julien.gauthier@boutique.test"),
    ("Karine Girard", "karine.girard@boutique.test"),
    ("Louis Simard", "louis.simard@boutique.test"),
    ("Maude Lapointe", "maude.lapointe@boutique.test"),
    ("Nicolas Perron", "nicolas.perron@boutique.test"),
    ("Olivia Renaud", "olivia.renaud@boutique.test"),
    ("Philippe Caron", "philippe.caron@boutique.test"),
    ("Rosalie Desjardins", "rosalie.desjardins@boutique.test"),
    ("Samuel Beaulieu", "samuel.beaulieu@boutique.test"),
    ("Thomas Bergeron", "thomas.bergeron@boutique.test"),
    ("Zoé Lévesque", "zoe.levesque@boutique.test")
];

foreach (var user in users)
{
    userServices.Add(user.Nom, user.Email);
}

// Adding products to the db
(string Nom, double Prix)[] products =
[
    ("Clavier mécanique", 89.99),
    ("Souris sans fil", 39.99),
    ("Écran 27 pouces", 249.90),
    ("Casque audio", 79.50),
    ("Webcam HD", 59.00),
    ("Micro USB", 99.00),
    ("Support laptop", 34.95),
    ("SSD 1 To", 119.99),
    ("Disque dur externe 2 To", 94.99),
    ("Hub USB-C", 44.90),
    ("Chaise ergonomique", 329.00),
    ("Bureau assis-debout", 459.00)
];

foreach (var product in products)
{
    productServices.Add(product.Nom, product.Prix);
}



// Users table
Console.WriteLine("List of all the users in the db");
var allUsers = userServices.GetAll();

if (allUsers.Count == 0)
{
    Console.WriteLine("No Users Found");
}
else
{
    int idWidth = Math.Max(2, allUsers.Max(u => u.Id.ToString().Length));
    int nomWidth = Math.Max(3, allUsers.Max(u => u.Nom.Length));
    int emailWidth = Math.Max(5, allUsers.Max(u => u.Email.Length));

    string line = $"+-{new string('-', idWidth)}-+-{new string('-', nomWidth)}-+-{new string('-', emailWidth)}-+";

    Console.WriteLine(line);
    Console.WriteLine($"| {"Id".PadRight(idWidth)} | {"Nom".PadRight(nomWidth)} | {"Email".PadRight(emailWidth)} |");
    Console.WriteLine(line);

    foreach (var u in allUsers.OrderBy(u => u.Id))
    {
        Console.WriteLine($"| {u.Id.ToString().PadRight(idWidth)} | {u.Nom.PadRight(nomWidth)} | {u.Email.PadRight(emailWidth)} |");
    }

    Console.WriteLine(line);
}

// Products table
Console.WriteLine("\nList of all the products in the db");
var allProducts = productServices.GetAll();

if (allProducts.Count == 0)
{
    Console.WriteLine("No Products Found");
}
else
{
    int idWidth = Math.Max(2, allProducts.Max(p => p.Id.ToString().Length));
    int nomWidth = Math.Max(3, allProducts.Max(p => p.Nom.Length));
    int prixWidth = Math.Max(4, allProducts.Max(p => p.Prix.ToString("0.00").Length));

    string line = $"+-{new string('-', idWidth)}-+-{new string('-', nomWidth)}-+-{new string('-', prixWidth)}-+";

    Console.WriteLine(line);
    Console.WriteLine($"| {"Id".PadRight(idWidth)} | {"Nom".PadRight(nomWidth)} | {"Prix".PadRight(prixWidth)} |");
    Console.WriteLine(line);

    foreach (var p in allProducts.OrderBy(p => p.Id))
    {
        Console.WriteLine($"| {p.Id.ToString().PadRight(idWidth)} | {p.Nom.PadRight(nomWidth)} | {p.Prix.ToString("0.00").PadRight(prixWidth)} |");
    }

    Console.WriteLine(line);
}

