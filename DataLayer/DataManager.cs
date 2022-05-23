using DataLayer.Model;
using DataLayer.Repositories.Factories;
using DataLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataManager
    {
        private readonly Irepo repo;
        public AdminUser User { get; set; }
        public DataManager()
        {
            try
            {
                repo = RepoFactory.GetRepo();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IList<AdminUser> GetAdminUsers()
        {
            return repo.GetAdminUsers();
        }
        public AdminUser AuthAdminUser(string username, string password)
        {
            return repo.AuthAdminUser(username, Cryptography.SHA512(password));
        }
        public IList<Recepie> GetRecepies()
        {
            return repo.GetRecepies();
        }

        public void CreateRecepie(Recepie recepie)
        {
            repo.CreateRecepie(recepie);
        }

        public void DeleteRecepie(Recepie recepie)
        {
            repo.DeleteRecepie(recepie);
        }

        public IList<Grocery> GetGroceries()
        {
            return repo.GetGroceries();
        }

        public void CreateGrocery(Grocery grocery)
        {
            repo.CreateGrocery(grocery);
        }

        public void DeleteGrocery(Grocery grocery)
        {
            repo.DeleteGrocery(grocery);
        }
    }
}
