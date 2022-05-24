using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.Interfaces
{
    public interface Irepo
    {
        IList<Grocery> GetGroceries();
        void CreateGrocery(Grocery grocery);
        void DeleteGrocery(Grocery grocery);
        IList<Recepie> GetRecepies();
        void CreateRecepie(Recepie recepie);
        void DeleteRecepie(Recepie recepie);
        IList<User> GetAdminUsers();
        User AuthAdminUser(string username, string password);
    }
}
