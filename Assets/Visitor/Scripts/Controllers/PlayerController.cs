using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [field: SerializeField] private List<BasePlayerComponent> PlayerComponents { get; set; }
    
    public void ReceivePowerUp(HealthAndManaPowerUp healthAndManaPowerUp)
    {
        foreach (var component in PlayerComponents)
        {
            component.Accept(healthAndManaPowerUp);
        }
    }
}
