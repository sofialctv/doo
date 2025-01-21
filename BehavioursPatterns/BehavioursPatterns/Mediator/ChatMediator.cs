using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Mediator
{
    public class ChatMediator : IMediator
    {
        private List<User> _users = new();
        public void RegisterUser(User user) { _users.Add(user); }
        public void SendMessage(string message, User user) { foreach (var u in _users.Where(u => u != user)) { Console.WriteLine($"{user.Name} to {u.Name}: {message}"); } }
    }
}
