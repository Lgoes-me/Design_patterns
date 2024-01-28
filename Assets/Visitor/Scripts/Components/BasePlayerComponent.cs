using UnityEngine;

public abstract class BasePlayerComponent: MonoBehaviour, IVisitable
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}