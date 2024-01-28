public class HealthPowerUp : IVisitor
{
    private int Health { get; }
    
    public HealthPowerUp(int health)
    {
        Health = health;
    }
    
    public void Visit(IVisitable visitable)
    {
        switch (visitable)
        {
            case HealthComponent healthComponent:
                Visit(healthComponent);
                break;
        }
    }

    private void Visit(HealthComponent healthComponent)
    {
        healthComponent.ReceiveHealth(Health);
    }
}