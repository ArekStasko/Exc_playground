using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_playground
{
    public class UserDetails
    {
        private Dictionary<Guid, User> _users;

        public UserDetails(Dictionary<Guid, User> data)
        {
            _users = data;
        }

        public Guid AddUser(User user)
        {
            var Id = Guid.NewGuid();
            _users.Add(Id, user);
            return Id;
        }

        public void DeleteUser(Guid Id)
        {
            if (_users.ContainsKey(Id))
                _users.Remove(Id);
        }

        public User GetUser(Guid Id)
        {
            if (_users.ContainsKey(Id))
                return _users[Id];

            return null;
        }

        public void PrintUsers()
        {
            Console.WriteLine("Users Data :");
            if (_users.Count == 0)
                return;

            foreach (var user in _users)
            {
                Console.WriteLine($"{user.Key} - {user.Value}");
            }
        }
    }

    public class User
    {
        public string Name { get; }
        public string Surname { get; }
        public string Email { get; }

        public User(string name, string surname, string email)
        {
            Name = name; 
            Surname = surname; 
            Email = email; 
        }

        public override string ToString()
        {
            return $"| {Name} | {Surname} | {Email} |";
        }
    }
}
