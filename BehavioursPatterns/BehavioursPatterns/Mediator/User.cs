using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Mediator
{
    public class User
{
    public string Name { get; }
    private IMediator _mediator;
    public User(string name, IMediator mediator) { Name = name; _mediator = mediator; _mediator.RegisterUser(this); }
    public void SendMessage(string message) { _mediator.SendMessage(message, this); }
}
}
