using UnityEngine;

namespace Command.Controllers.PlayerCommands
{
    public class PlayerAttackCommand :  IPlayerCommand
    {
        private EnemyController Enemy { get; set; }

        public PlayerAttackCommand(EnemyController enemy)
        {
            Enemy = enemy;
        }

        public void Execute(PlayerController playerController)
        {
            Debug.Log("Player attacks the enemy");
        }
    }
}