# Gestion Utilisateurs - MVC en C#

## 🎯 Objectif
Ce projet est une application console en C# permettant de gérer des utilisateurs en respectant le principe **MVC** et en implémentant les opérations **CRUD** (Create, Read, Update, Delete).

## 🏗️ Structure du projet
- **Models** : contient la classe `User` représentant un utilisateur.
- **Repositories** : gère la persistance des données (simulation avec une liste en mémoire).
- **Services** : encapsule la logique métier et délègue au repository.
- **Controllers** : gère les interactions avec l’utilisateur via la console.
- **Program.cs** : point d’entrée de l’application, lance le menu interactif.

## ⚙️ Fonctionnalités
- Ajouter un utilisateur (avec vérification de l’unicité de l’email).
- Lister tous les utilisateurs.
- Modifier un utilisateur existant.
- Supprimer un utilisateur.
- Menu interactif en console.

## 🚀 Exécution
1. Cloner le projet :
   ```bash
   git clone https://github.com/tonpseudo/GestionUtilisateurs.git
