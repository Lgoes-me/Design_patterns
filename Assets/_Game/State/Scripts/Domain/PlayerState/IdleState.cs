using State.Controllers;

namespace State.Domain.PlayerState
{
    public class IdleState : IState
    {
        public PlayerController PlayerController { get; set; }
        
        public void OnStateEnter()
        {
            PlayerController.TittleText.SetText("IdleState");
            
            PlayerController.TopButtonText.SetText("Prepare Attack");
            PlayerController.BottomButtonText.SetText("Prepare Defense");
        }

        public void OnStateExit()
        {
            
        }

        public void PressTopButton()
        {
            PlayerController.StateMachine.ChangeState(new AttackState());
        }

        public void PressBottomButton()
        {
            PlayerController.StateMachine.ChangeState(new DefenseState());
        }
    }
}