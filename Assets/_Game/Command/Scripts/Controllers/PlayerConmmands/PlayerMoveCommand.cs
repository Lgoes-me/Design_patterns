using UnityEngine;

namespace Command.Controllers.PlayerCommands
{
    public class PlayerMoveCommand :  IPlayerCommand
    {
        private Vector3 Position { get; set; }

        public PlayerMoveCommand(Vector3 position)
        {
            Position = position;
        }

        public void Execute(PlayerController playerController)
        {
            Debug.Log("Player moves to new position");
        }
    }
}