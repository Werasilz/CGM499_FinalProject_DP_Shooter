using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupController : MonoBehaviour, IPowerupElement
{
    private List<IPowerupElement> _powerElements =
        new List<IPowerupElement>();

    void Start()
    {
        _powerElements.Add(gameObject.AddComponent<PowerHealth>());
        _powerElements.Add(gameObject.AddComponent<PowerSpeed>());
    }

    public void Accept(IVisitor visitor)
    {
        foreach (IPowerupElement element in _powerElements)
        {
            element.Accept(visitor);
        }
    }

    public void Deline(IVisitor visitor)
    {
        foreach (IPowerupElement element in _powerElements)
        {
            element.Deline(visitor);
        }
    }
}
