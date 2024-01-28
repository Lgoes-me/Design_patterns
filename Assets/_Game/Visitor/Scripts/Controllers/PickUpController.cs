using UnityEngine;

public class PickUpController : MonoBehaviour
{
    [field: SerializeField] private PlayerController PlayerController { get; set; }

    public void PickUpTheHealthAndManaPowerUp()
    {
        var powerUp = new HealthAndManaPowerUp(10, 10);
        PlayerController.ReceivePowerUp(powerUp);
    }

    public void PickUpTheHealthPowerUp()
    {
        var powerUp = new HealthPowerUp(5);
        PlayerController.ReceivePowerUp(powerUp);
    }

    public void PickUpTheManaPowerUp()
    {
        var powerUp = new ManaPowerUp(3);
        PlayerController.ReceivePowerUp(powerUp);
    }
}