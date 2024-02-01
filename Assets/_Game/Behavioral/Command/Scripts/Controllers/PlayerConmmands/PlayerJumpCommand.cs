using UnityEngine;

namespace Command.Controllers.PlayerCommands
{
    public class PlayerJumpCommand :  IPlayerCommand
    {
        public void Execute(PlayerController playerController)
        {
            Debug.Log("Player jumps");
        }
    }
}