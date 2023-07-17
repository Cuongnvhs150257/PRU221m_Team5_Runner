using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //private MonsterFactory monsterFactory;

    public MonsterAbstractFactory monsterFactories;


    public int poolSize = 10;
    public float spawnRate = 1f;
    public float maxX;
    public float Y;
    public float minX;
    private List<GameObject> creepList;
    private List<GameObject> creepPool;

    private void Start()
    {

        creepList = new List<GameObject>();
        creepPool = new List<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject monster = monsterFactories.CreateMonster();
            monster.SetActive(false);
            creepPool.Add(monster);
        }
        StartCoroutine(SpawnD());
    }

    private IEnumerator SpawnD()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);

            float randomX = Random.Range(minX, maxX);

            if (creepPool.Count > 0)
            {
                GameObject creep = creepPool[0];
                creep.SetActive(true);
                creep.transform.position = transform.position + new Vector3(randomX, Y, 0);
                creepList.Add(creep);
                creepPool.RemoveAt(0);
            }
        }
    }

    public void RecycleCreep(GameObject creep)
    {
        if (creepList.Remove(creep))
        {
            creep.SetActive(false);
            creepPool.Add(creep);
        }
    }

}
