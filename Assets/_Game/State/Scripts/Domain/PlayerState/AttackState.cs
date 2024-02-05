using State.Controllers;
using UnityEngine;

namespace State.Domain.PlayerState
{
    public class AttackState : IState
    {
        public PlayerController PlayerController { get; set; }
        
        private int Energy { get; set; }
        
        public void OnStateEnter()
        {
            PlayerController.TittleText.SetText("AttackState");
            
            PlayerController.TopButtonText.SetText("ATTACK!");
            PlayerController.BottomButtonText.SetText("Idle");

            Energy = 3;
        }

        public void OnStateExit()
        {
            
        }

        public void PressTopButton()
        {
            Debug.Log("Attack");

            Energy -= 1;

            if (Energy == 0)
            {
                Debug.Log("Tired, going to Idle");
                PlayerController.StateMachine.ChangeState(new IdleState());
            }
        }

        public void PressBottomButton()
        {
            PlayerController.StateMachine.ChangeState(new IdleState());
        }
    }
}