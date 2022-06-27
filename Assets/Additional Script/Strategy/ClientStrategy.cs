using UnityEngine;
using System.Collections.Generic;

public class ClientStrategy : Singleton<ClientStrategy>
{
    private List<IManeuverBehaviour> _components = new List<IManeuverBehaviour>();

    public void ApplyRandomStrategies(GameObject _enemy)
    {
        _components.Add(_enemy.AddComponent<WeavingManeuver>());
        _components.Add(_enemy.AddComponent<BoppingManeuver>());
        _components.Add(_enemy.AddComponent<FallbackManeuver>());

        int index = Random.Range(0, _components.Count);

        _enemy.GetComponent<Enemy>().ApplyStrategy(_components[index]);
    }
}