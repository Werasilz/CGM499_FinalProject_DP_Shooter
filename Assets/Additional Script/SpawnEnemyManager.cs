using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyManager : MonoBehaviour
{
    public GameObject prefab;
    public float time;

    private void Start()
    {
        StartCoroutine(Spawning(prefab));
    }

    IEnumerator Spawning(GameObject prefab)
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            Instantiate(prefab, this.transform);
        }
    }
}
