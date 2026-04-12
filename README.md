# Mise en application – Cours Interface graphique – Partie V – Initiation à l'ORM Entity Framework

**Séance 11** (Le 07/04/2026)

---

## Exercice 01: Création d'une base de données et des entités de base

**Objectif:** Comprendre la création d'une base de données et de ses entités.

**Consignes:**
1. Créez un projet console .NET Core.
2. Installez Entity Framework Core avec SQL Server.
3. Créez les entités `Utilisateur`(Id, Nom, Email) et `Produit`(Id, Nom, Prix).
4. Configurez le `DbContext` et appliquez une migration.
5. Vérifiez que la base de données est bien créée.

---

## Exercice 02: Ajout et récupération de données

**Objectif:** Manipuler les données avec Entity Framework Core.

**Consignes:**
1. Ajoutez plusieurs utilisateurs et produits dans la base de données.
2. Affichez tous les utilisateurs et produits dans la console.
3. Implémentez une recherche de produit par Id.
4. Filtrez les produits ayant un prix supérieur à 50$.

---

## Exercice 03: Relations One-to-Many (Utilisateur → Commande)

**Objectif:** Mettre en place une relation entre deux entités.

**Consignes:**
1. Ajoutez l'entité `Commande`(Id, Date, UtilisateurId).
2. Configurez la relation One-to-Many entre `Utilisateur` et `Commande`.
3. Ajoutez des commandes associées aux utilisateurs.
4. Récupérez et affichez les commandes avec leur utilisateur associé.

---

## Exercice 04: Relations Many-to-Many (Commande ↔ Produit)

**Objectif:** Travailler avec une relation Many-to-Many.

**Consignes:**
1. Créez une table d'association `CommandeProduit`(CommandeId, ProduitId, Quantité).
2. Configurez la relation Many-to-Many entre `Commande` et `Produit`.
3. Ajoutez des produits à des commandes.
4. Affichez une commande avec la liste des produits commandés.

---

## Exercice 05: Gestion des mises à jour et suppressions

**Objectif:** Modifier et supprimer des données avec Entity Framework Core.

**Consignes:**
1. Mettez à jour l'Email d'un utilisateur.
2. Supprimez un produit spécifique.
3. Supprimez un utilisateur et vérifiez si ses commandes sont bien supprimées en cascade.

---

## Exercice 06: Importation de données depuis un fichier CSV

**Objectif:** Lire un fichier CSV (avec CsvHelper) et transférer le contenu vers une base de données.

**Consignes:**
1. Créez un fichier `produits.csv` contenant Nom, Prix.
2. Écrivez un programme en C# pour lire ce fichier et insérer les produits dans la base de données.
3. Affichez dans la console les produits importés.

---

## Exercice 07: Migration vers MySQL Server

**Objectif:** Travailler avec MySQL et Entity Framework Core.

**Consignes:**
1. Installez MySQL Server et MySQL Workbench.
2. Ajoutez le package `Pomelo.EntityFrameworkCore.MySql`.
3. Modifiez le `DbContext` pour utiliser MySQL au lieu de SQL Server.
4. Testez les opérations CRUD avec MySQL.

---

## Exercice 08: Création d'une application WPF avec MVVM

**Objectif:** Développer une application WPF avec une architecture MVVM.

**Consignes:**
1. Créez un projet WPF.
2. Implémentez MVVM avec une vue permettant d'afficher les utilisateurs.
3. Utilisez un `ObservableCollection` pour la liste des utilisateurs.
4. Chargez les utilisateurs depuis la base de données et affichez-les.

---

## Exercice 09: Ajout d'utilisateurs via l'interface WPF

**Objectif:** Permettre l'ajout d'utilisateurs via une interface graphique.

**Consignes:**
1. Ajoutez un formulaire permettant d'entrer un nom et un Email.
2. Ajoutez un bouton « Ajouter » qui insère un utilisateur dans la base de données.
3. Rafraîchissez la liste après l'ajout.

---

## Exercice 10: Gestion des commandes dans l'application WPF

**Objectif:** Permettre la gestion des commandes via WPF.

**Consignes:**
1. Ajoutez un `ListView` affichant les commandes d'un utilisateur sélectionné.
2. Ajoutez un bouton « Ajouter commande » pour ajouter une commande à un utilisateur.
3. Rafraîchissez la liste après ajout.

---

## Exercice 11: Gestion et affichage des produits

**Objectif:** Travailler avec la liste des produits dans WPF.

**Consignes:**
1. Affichez la liste des produits dans un `ListView` (dans la base de données).
2. Ajoutez un bouton permettant de supprimer un produit.
3. Ajoutez un champ permettant de modifier le prix d'un produit.

---

## Exercice 12: Création d'un Dashboard récapitulatif

**Objectif:** Afficher un résumé des données sous forme de tableau de bord.

**Consignes:**
1. Affichez le nombre total d'utilisateurs, de commandes et de produits.
2. Ajoutez un graphique des ventes par mois.
3. Ajoutez un bouton permettant d'exporter les données en CSV.

---
