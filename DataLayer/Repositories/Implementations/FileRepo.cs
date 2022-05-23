using DataLayer.Model;
using DataLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.Implementations
{
    public class FileRepo : Irepo
    {
        public const string ADMIN_USERS_PATH = "admin_users.txt";
        public const string GROCERIES_PATH = "groceries.txt";
        public const string RECEPIES_PATH = "recepies.txt";
        public FileRepo()
        {
            if (!File.Exists(ADMIN_USERS_PATH))
            {
                File.Create(ADMIN_USERS_PATH).Close();
                IList<AdminUser> admins = new List<AdminUser>
                {
                    new AdminUser(firstName: "Marta", lastName: "Vlahek", username: "mvlahek", password: Cryptography.SHA512("admin")),
                    new AdminUser(firstName: "Lucija", lastName: "Zidaric", username: "lzidaric", password: Cryptography.SHA512("admin"))
                };
                File.WriteAllLines(ADMIN_USERS_PATH, admins.Select(admin => admin.FormatForFileLine()));
            }
            if(!File.Exists(GROCERIES_PATH))
                File.Create(GROCERIES_PATH);
            if (!File.Exists(RECEPIES_PATH))
                File.Create(RECEPIES_PATH);
            CreateMissingGroceriesFromRecepies();
        }
        public void CreateMissingGroceriesFromRecepies()
        {
            var recepies = this.GetRecepies();
            var groceries = this.GetGroceries();
            foreach (var recepie in recepies)
            {
                foreach (var ingridient in recepie.Ingridients)
                {
                    try
                    {
                        this.CreateGrocery(ingridient.Grocery);
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
            }
        }
        public IList<AdminUser> GetAdminUsers()
        {
            string[] lines = File.ReadAllLines(ADMIN_USERS_PATH);
            return lines.ToList().Select(line => AdminUser.ParseFromFileLine(line)).ToList();
        }
        public AdminUser AuthAdminUser(string username, string password)
        {
            var authadmin = this.GetAdminUsers()
                .FirstOrDefault(admin => admin.Username.Equals(username) && admin.Password.Equals(password));
            return authadmin;
        }
        public IList<Recepie> GetRecepies()
        {
            string[] lines = File.ReadAllLines(RECEPIES_PATH);
            var recepies =  lines.ToList().Select(line => Recepie.ParseFromFileLine(line)).ToList();
            return recepies;
        }

        public void CreateRecepie(Recepie recepie)
        {
            var recepies = this.GetRecepies();
            if (recepies.FirstOrDefault(r => r.Name.Equals(recepie.Name)) != null)
                throw new Exception("Recept vec postoji");
            recepies.Add(recepie);
            File.WriteAllLines(RECEPIES_PATH, recepies.Select(r => r.FormatForFileLine()));
        }

        public void DeleteRecepie(Recepie recepie)
        {
            var recepies = this.GetRecepies();
            if (recepies.FirstOrDefault(r => r.Name.Equals(recepie.Name)) == null)
                throw new Exception("Recept koji zelite obrisati ne postoji");
            recepies.Remove(recepie);
            File.WriteAllLines(RECEPIES_PATH, recepies.Select(r => r.FormatForFileLine()));
        }

        public IList<Grocery> GetGroceries()
        {
            string[] lines = File.ReadAllLines(GROCERIES_PATH);
            return lines.ToList().Select(line => Grocery.ParseFromFileLine(line)).ToList();
        }

        public void CreateGrocery(Grocery grocery)
        {
            var groceries = this.GetGroceries();
            if (groceries.FirstOrDefault(r => r.Name.Equals(grocery.Name)) != null)
                throw new Exception("Namirnica vec postoji");
            groceries.Add(grocery);
            File.WriteAllLines(GROCERIES_PATH, groceries.Select(r => r.FormatForFileLine()));
        }

        public void DeleteGrocery(Grocery grocery)
        {
            var groceries = this.GetGroceries();
            if (groceries.FirstOrDefault(r => r.Name.Equals(grocery.Name)) == null)
                throw new Exception("Namirnica koju zelite obrisati ne postoji");
            groceries.Remove(grocery);
            File.WriteAllLines(GROCERIES_PATH, groceries.Select(r => r.FormatForFileLine()));
        }
    }
}
