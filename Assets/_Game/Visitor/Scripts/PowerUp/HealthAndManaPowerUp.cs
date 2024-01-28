public class HealthAndManaPowerUp : BasePowerUp
{
    private int Health { get; }
    private int Mana { get; }

    public HealthAndManaPowerUp(int health, int mana)
    {
        Health = health;
        Mana = mana;
    }

    public override void Visit(IVisitable visitable)
    {
        switch (visitable)
        {
            case HealthComponent healthComponent:
                Visit(healthComponent);
                break;
            case ManaComponent manaComponent:
                Visit(manaComponent);
                break;
        }
    }

    private void Visit(HealthComponent healthComponent)
    {
        healthComponent.ReceiveHealth(Health);
    }

    private void Visit(ManaComponent manaComponent)
    {
        manaComponent.ReceiveMana(Mana);
    }
}