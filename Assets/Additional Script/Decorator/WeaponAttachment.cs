using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewWeaponAttachment", menuName = "Weapon/Attachment", order = 1)]
public class WeaponAttachment : ScriptableObject, IWeapon
{
    [Range(1, 30)]
    [SerializeField] private int _magazine_max;

    [Range(-0.075f, -0.01f)]
    [SerializeField] private float _firerate;

    [Range(-0.1f, -3f)]
    [SerializeField] private float _vertical_force;

    [Range(-0.1f, -3f)]
    [SerializeField] private float _horizontal_force;

    public int magazine_max
    {
        get { return _magazine_max; }
    }
    public float firerate
    {
        get { return _firerate; }
    }
    public float vertical_force
    {
        get { return _vertical_force; }
    }
    public float horizontal_force
    {
        get { return _horizontal_force; }
    }
}
