public class ManaPowerUp: IVisitor
{
    private int Mana { get; }
        
    public ManaPowerUp(int mana)
    {
        Mana = mana;
    }

    public void Visit(IVisitable visitable)
    {
        switch (visitable)
        {
            case ManaComponent manaComponent:
                Visit(manaComponent);
                break;
        }
    }
    
    private void Visit(ManaComponent manaComponent)
    {
        manaComponent.ReceiveMana(Mana);
    }
}