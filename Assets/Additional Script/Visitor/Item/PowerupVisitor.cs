using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupVisitor : MonoBehaviour
{
    public PowerUpItem powerup;

    private void OnTriggerEnter(Collider other)
    {
        PowerupController controller = other.GetComponent<PowerupController>();

        if (controller)
        {
            controller.Accept(powerup);
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;

            StartCoroutine(Deline(controller));
        }
    }

    IEnumerator Deline(PowerupController controller)
    {
        yield return new WaitForSeconds(powerup.cooldownTime);
        controller.Deline(powerup);
        Destroy(gameObject);
    }
}
