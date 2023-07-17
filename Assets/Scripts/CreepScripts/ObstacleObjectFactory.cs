using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleObjectFactory : MonsterAbstractFactory
{
    public GameObject prefab;

    public override GameObject CreateMonster()
    {
        GameObject monster = Instantiate(prefab);
        //Monster monster = monsterGO.GetComponent<Monster>();
        return monster;
    }
}
