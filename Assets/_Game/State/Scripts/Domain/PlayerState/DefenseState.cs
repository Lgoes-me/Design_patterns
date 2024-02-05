using State.Controllers;
using UnityEngine;

namespace State.Domain.PlayerState
{
    public class DefenseState : IState
    {
        public PlayerController PlayerController { get; set; }
        
        public void OnStateEnter()
        {
            PlayerController.TittleText.SetText("DefenseState");
            
            PlayerController.TopButtonText.SetText("DEFEND!");
            PlayerController.BottomButtonText.SetText("Prepare Attack");
        }

        public void OnStateExit()
        {
            
        }

        public void PressTopButton()
        {
            Debug.Log("Defend");
        }

        public void PressBottomButton()
        {
            PlayerController.StateMachine.ChangeState(new AttackState());
        }
    }
}