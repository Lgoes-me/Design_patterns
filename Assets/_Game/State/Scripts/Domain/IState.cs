using State.Controllers;

namespace State.Domain
{
    public interface IState
    {
        PlayerController PlayerController { get; set; }

        void Init(PlayerController playerController)
        {
            PlayerController = playerController;
        }
        
        void OnStateEnter();
        void OnStateExit();

        void PressTopButton();
        void PressBottomButton();
    }
}