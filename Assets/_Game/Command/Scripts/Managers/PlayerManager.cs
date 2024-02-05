using Command.Controllers;
using Command.Controllers.PlayerCommands;
using UnityEngine;

namespace Command.Managers
{
    public class PlayerManager : MonoBehaviour
    {
        [field: SerializeField]
        private PlayerController PlayerController { get; set; }
        
        [field: SerializeField]
        private EnemyController EnemyController { get; set; }

        public void CommandPlayerToAttack()
        {
            var command = new PlayerAttackCommand(EnemyController);
            PlayerController.AddNewCommand(command);
        }
        
        public void CommandPlayerToJump()
        {
            var command = new PlayerJumpCommand();
            PlayerController.AddNewCommand(command);
        }
        
        public void CommandPlayerToMove()
        {
            var command = new PlayerMoveCommand(Vector3.zero);
            PlayerController.AddNewCommand(command); 
        }

        public void ExecuteNextCommand()    
        {
            PlayerController.ExecuteNextCommand();
        }
    }
}