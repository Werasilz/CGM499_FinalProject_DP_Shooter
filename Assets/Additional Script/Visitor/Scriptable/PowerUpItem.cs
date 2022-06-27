using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPowerUp", menuName = "PowerUp", order = 1)]
public class PowerUpItem : ScriptableObject, IVisitor
{
    public string title;
    public float cooldownTime = 3;

    [Range(1, 100f)]
    public int healthBoost;

    [Range(1, 500)]
    public float speedBoost;

    public void Visit(PowerHealth powerHealth)
    {
        var newHealthBoost = powerHealth.player_health + healthBoost;

        powerHealth.player_health = newHealthBoost;
    }

    public void Visit(PowerSpeed powerSpeed)
    {
        var newSpeedBoost = powerSpeed.walk_speed + speedBoost;

        powerSpeed.walk_speed = newSpeedBoost;
    }

    public void Unvisit(PowerHealth powerHealth)
    {
        powerHealth.player_health -= healthBoost;
    }

    public void Unvisit(PowerSpeed powerSpeed)
    {
        powerSpeed.walk_speed -= speedBoost;
    }
}