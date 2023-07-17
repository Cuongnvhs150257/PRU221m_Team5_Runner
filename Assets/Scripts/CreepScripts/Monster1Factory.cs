using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster1Factory : MonsterAbstractFactory
{
    private GameObject prefab;

    private void Awake()
    {
        Debug.Log(1);
        prefab = Resources.Load<GameObject>("Creep1");
    }

    public override GameObject CreateMonster()
    {
        prefab = Resources.Load<GameObject>("Creep1");
        GameObject monster = Instantiate(prefab);
        //Monster monster = monsterGO.GetComponent<Monster>();
        return monster;
    }
}
