using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damagable : MonoBehaviour
{
    public int health = 100;
    public GameObject powerUp;
    public PowerUpItem[] powerUpItems;

    public void takeDamage(int dmg)
    {
        Debug.Log("TEST");
        health -= dmg;
    }

    private void Update()
    {
        if (health <= 0)
        {
            health = 0;
            SpawnPowerUp();
            Destroy(gameObject);
        }
    }

    void SpawnPowerUp()
    {
        int i = Random.Range(0, 5);

        if (i == 0)
        {
            GameObject power = Instantiate(powerUp, transform.position, transform.rotation);
            power.GetComponent<PowerupVisitor>().powerup = Random.Range(0, 2) == 0 ? powerUpItems[0] : powerUpItems[1];
        }
    }
}
