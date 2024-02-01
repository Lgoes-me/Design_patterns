using System.Collections.Generic;
using Command.Controllers.PlayerCommands;
using UnityEngine;

namespace Command.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private Queue<IPlayerCommand> Commands { get; set; }

        private void Start()
        {
            Commands = new Queue<IPlayerCommand>();
        }

        public void AddNewCommand(IPlayerCommand command)
        {
            Debug.Log($"{command}");
            Commands.Enqueue(command);
        }

        public void ExecuteNextCommand()
        {
            if (!Commands.TryDequeue(out var command))
                return;
            
            command.Execute(this);
        }
        
    }
}