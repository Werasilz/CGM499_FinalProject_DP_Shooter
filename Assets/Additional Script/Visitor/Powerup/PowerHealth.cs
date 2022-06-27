using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerHealth : MonoBehaviour, IPowerupElement
{
    public int player_health = 100;

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public void Deline(IVisitor visitor)
    {
        visitor.Unvisit(this);
    }
}
