using GestionUtilisateurs.Models;
using GestionUtilisateurs.Repositories;

namespace GestionUtilisateurs.Services
{
    /// <summary>
    /// Service de gestion des utilisateurs. 
    /// Encapsule la logique métier et délègue au repository.
    /// </summary>
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// Crée un nouvel utilisateur et retourne l'objet créé.
        /// </summary>
        public User CreateUser(User user)
        {
            return _userRepository.CreateUser(user);
        }

        /// <summary>
        /// Supprime un utilisateur par son identifiant.
        /// </summary>
        public void DeleteUser(long id)
        {
            _userRepository.DeleteUser(id);
        }

        /// <summary>
        /// Retourne la liste de tous les utilisateurs.
        /// </summary>
        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        /// <summary>
        /// Recherche un utilisateur par email.
        /// </summary>
        public User? FindUserByEmail(string email)
        {
            return _userRepository.GetUserByEmail(email);
        }

        /// <summary>
        /// Recherche un utilisateur par identifiant.
        /// </summary>
        public User? FindUserById(long id)
        {
            return _userRepository.GetUserById(id);
        }

        /// <summary>
        /// Met à jour un utilisateur et retourne l'objet modifié.
        /// </summary>
        public User? UpdateUser(User user)
        {
            return _userRepository.UpdateUser(user);
        }
    }
}
