using State.Controllers;

namespace State.Domain
{
    public class StateMachine
    {
        private IState State { get; set; }

        private PlayerController PlayerController { get; set; }
        
        public StateMachine(PlayerController playerController)
        {
            PlayerController = playerController;
        }

        public void ChangeState(IState state)
        {
            State?.OnStateExit();
            State = state;
            State.Init(PlayerController);
            State.OnStateEnter();
        }

        public void PressTopButton()
        {
            State.PressTopButton();
        }

        public void PressBottomButton()
        {
            State.PressBottomButton();
        }
    }
}