﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioursPatterns.Command
{
    public class CommandManager
    {
        private Stack<ICommand> _commands = new();
        private Stack<ICommand> _undoneCommands = new();
        public void ExecuteCommand(ICommand command) { command.Execute(); _commands.Push(command); _undoneCommands.Clear(); }
        public void Undo() { if (_commands.Any()) { var command = _commands.Pop(); command.Undo(); _undoneCommands.Push(command); } }
        public void Redo() { if (_undoneCommands.Any()) { var command = _undoneCommands.Pop(); command.Execute(); _commands.Push(command); } }
    }
}
