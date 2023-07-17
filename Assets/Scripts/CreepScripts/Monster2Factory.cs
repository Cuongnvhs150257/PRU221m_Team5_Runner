using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster2Factory : MonsterAbstractFactory
{
    public GameObject prefab;

    public override GameObject CreateMonster()
    {
        GameObject monster = Instantiate(prefab);
        //FlyMonter monster = monsterGO.GetComponent<FlyMonter>();
        return monster;
    }
}
