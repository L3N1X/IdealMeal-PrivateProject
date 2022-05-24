using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    //Ova klasa prestavlja korisnika 
    public class User
    {
        //Ovaj korisnik ima:
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        //Konstruktor: korisnik se ne može kreirati bez da mu se da ime prezime, korisnicko ime i password
        public User(string name, string lastName, string username, string password)
        {
            Name = name;
            LastName = lastName;
            Username = username;
            Password = password;
        }
        //Dohvati puno ime npr "Maja" + " " + "Krmpotic"
        public string FullName()
        {
            return Name + " " + LastName;
        }
    }
}
