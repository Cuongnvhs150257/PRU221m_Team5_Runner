using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster2Factory : MonsterAbstractFactory
{
    private GameObject prefab;

    private void Awake()
    {
        prefab = Resources.Load<GameObject>("FlyCreep");
    }

    public override GameObject CreateMonster()
    {
        prefab = Resources.Load<GameObject>("FlyCreep");
        GameObject monster = Instantiate(prefab);
        //FlyMonter monster = monsterGO.GetComponent<FlyMonter>();
        return monster;
    }
}
