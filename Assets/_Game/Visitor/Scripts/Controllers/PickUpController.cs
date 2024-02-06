using UnityEngine;
using Visitor.PowerUps;

namespace Visitor.Controllers
{
    public class PickUpController : MonoBehaviour
    {
        [field: SerializeField] private PlayerController PlayerController { get; set; }
        [field: SerializeField] private BasePowerUp PowerUp { get; set; }

        public void PickUpThePowerUp()
        {
            PlayerController.ReceivePowerUp(PowerUp);
        }
    }
}