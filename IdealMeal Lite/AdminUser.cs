using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class AdminUser
    {
        public const char DEL = '|';
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }

        public AdminUser(string firstName, string lastName, string username, string password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Username = username;
            this.Password = password;
        }

        public static AdminUser ParseFromFileLine(string line)
        {
            string[] data = line.Split(DEL);
            return new AdminUser
                (
                firstName: data[0],
                lastName: data[1],
                username: data[2],
                password: data[3]
                );
        }

        public string FormatForFileLine()
            => $"{this.FirstName}{DEL}" +
            $"{this.LastName}{DEL}" +
            $"{this.Username}{DEL}" +
            $"{this.Password}";

        public override string ToString()
            => $"{this.FirstName} {this.LastName}";
    }
}
