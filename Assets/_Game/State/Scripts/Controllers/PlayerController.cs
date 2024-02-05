using State.Domain;
using State.Domain.PlayerState;
using UnityEngine;
using TMPro;

namespace State.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [field: SerializeField]
        public TextMeshProUGUI TittleText { get; private set; }
        
        [field: SerializeField]
        public TextMeshProUGUI TopButtonText { get; private set; }
        
        [field: SerializeField]
        public TextMeshProUGUI BottomButtonText { get; private set; }

        public StateMachine StateMachine { get; private set; }
        
        private void Start()
        {
            StateMachine = new StateMachine(this);
            StateMachine.ChangeState(new IdleState());
        }

        public void PressTopButton()
        {
            StateMachine.PressTopButton();
        }

        public void PressBottomButton()
        {
            StateMachine.PressBottomButton();
        }
    }
}