
public class Weapon : IWeapon
{
    private readonly WeaponConfig _config;

    public Weapon(WeaponConfig weaponConfig)
    {
        _config = weaponConfig;
    }

    public int magazine_max
    {
        get { return _config.magazine_max; }
    }

    public float firerate
    {
        get { return _config.firerate; }
    }

    public float vertical_force
    {
        get { return _config.vertical_force; }
    }

    public float horizontal_force
    {
        get { return _config.horizontal_force; }
    }
}
