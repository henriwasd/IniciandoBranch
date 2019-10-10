using LibrarySimple.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySimple.Controller
{
    public class UserController
    {
        UserContextDB contextDB = new UserContextDB();

        /// <summary>
        /// Metodo que lista os usuarios
        /// </summary>
        /// <returns>Retorna uma lista de usuarios</returns>
        public IQueryable<User> GetUsers()
        {
            return contextDB.Users.Where(x => x.Ativo == true);
        }

        /// <summary>
        /// Metodo para adicionar nomes
        /// </summary>
        /// <param name="user">Entrada do usuario</param>
        /// <returns>Retorna se foi adiciona com sucesso ou não</returns>
        public bool AddUser(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Name))
                return false;

            contextDB.Users.Add(user);
            contextDB.SaveChanges();
            return true;
        }
    }
}
