using UnityEngine;

public class PickUpController : MonoBehaviour
{
    [field: SerializeField] private PlayerController PlayerController { get; set; }
    private HealthAndManaPowerUp PowerUp { get; set; }

    private void Start()
    {
        PowerUp = new HealthAndManaPowerUp(10, 10);
    }

    public void PickUpThePowerUp()
    {
        PlayerController.ReceivePowerUp(PowerUp);
    }
}
