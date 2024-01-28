using UnityEngine;

public class ManaComponent : BasePlayerComponent
{
    [field: SerializeField] private int Mana { get; set; }

    public void ReceiveMana(int mana)
    {
        Mana += mana;
    }
}
