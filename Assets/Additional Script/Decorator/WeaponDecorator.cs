using UnityEngine;

public class WeaponDecorator : IWeapon
{
    private readonly IWeapon _unDecoratedWeapon;
    private readonly WeaponAttachment _attachment;

    public WeaponDecorator(IWeapon weapon, WeaponAttachment attachment)
    {
        _attachment = attachment;
        _unDecoratedWeapon = weapon;
        Debug.Log(_unDecoratedWeapon);
    }

    public int magazine_max
    {
        get { return _unDecoratedWeapon.magazine_max + _attachment.magazine_max; }
    }

    public float firerate
    {
        get { return _unDecoratedWeapon.firerate + _attachment.firerate; }
    }

    public float vertical_force
    {
        get { return _unDecoratedWeapon.vertical_force + _attachment.vertical_force; }
    }

    public float horizontal_force
    {
        get { return _unDecoratedWeapon.horizontal_force + _attachment.horizontal_force; }
    }
}
