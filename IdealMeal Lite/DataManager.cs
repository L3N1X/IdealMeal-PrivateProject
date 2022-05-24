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
        public User User { get; set; }
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
            User = repo.AuthAdminUser("lzidaric", Cryptography.SHA512("admin"));
        }

        public IList<Recepie> GetValidRecepies(IList<Ingridient> ingridients)
        {
            IList<Recepie> allrecepies = repo.GetRecepies();
            IList<Recepie> validRecepies = new List<Recepie>();
            allrecepies.ToList().ForEach(recepie => { if (recepie.CanMakeWithGivenIngridients(ingridients)) { validRecepies.Add(recepie); } });
            return validRecepies;
        }

        public IList<User> GetAdminUsers()
        {
            return repo.GetAdminUsers();
        }
        public User AuthAdminUser(string username, string password)
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
