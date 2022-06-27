using UnityEngine;
using System.Collections;

public class WeavingManeuver : MonoBehaviour, IManeuverBehaviour
{

    public void Maneuver(Enemy enemy)
    {
        StartCoroutine(Weave(enemy));
    }

    IEnumerator Weave(Enemy enemy)
    {
        float time;
        bool isReverse = false;
        float speed = enemy.speed;
        Vector3 startPosition = enemy.transform.position;
        Vector3 endPosition = startPosition;
        endPosition.x = enemy.weavingDistance + (Random.Range(-20f, 20f));

        while (true)
        {
            time = 0;
            Vector3 start = enemy.transform.position;
            Vector3 end =
                (isReverse) ? startPosition : endPosition;

            while (time < speed)
            {
                enemy.transform.position =
                    Vector3.Lerp(start, end, time / speed);

                time += Time.deltaTime;

                yield return null;
            }

            yield return new WaitForSeconds(1);
            isReverse = !isReverse;
        }
    }
}