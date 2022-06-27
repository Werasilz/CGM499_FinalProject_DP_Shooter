using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSpeed : MonoBehaviour, IPowerupElement
{
    public float walk_speed = 1.0f;

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public void Deline(IVisitor visitor)
    {
        visitor.Unvisit(this);
    }
}
