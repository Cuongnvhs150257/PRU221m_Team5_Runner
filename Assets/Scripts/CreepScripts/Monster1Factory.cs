using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster1Factory : MonsterAbstractFactory
{
    private GameObject prefab;

    public List<string> monsterNames;

    public override GameObject CreateMonster()
    {
        monsterNames = new List<string>();

        monsterNames.Add("Creep1");
        monsterNames.Add("FlyCreep");
        monsterNames.Add("ObstacleObject");
        monsterNames.Add("ObstacleObject2");

        for (int i = 0; i < monsterNames.Count; i++)
        {
            prefab = Resources.Load<GameObject>(monsterNames[Random.Range(0, monsterNames.Count)]);
        }
        GameObject monster = Instantiate(prefab);
        //Monster monster = monsterGO.GetComponent<Monster>();
        return monster;
    }
}
