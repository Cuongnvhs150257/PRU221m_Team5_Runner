using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCreep : MonoBehaviour
{
    public GameObject[] creepPrefabs;
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

        float randomX = Random.Range(minX, maxX);

        // Kh?i t?o pool ban ??u v?i s? l??ng creep t?i ?a
        for (int i = 0; i < poolSize; i++)
        {
            GameObject creep = Instantiate(creepPrefabs[Random.Range(0, creepPrefabs.Length)], transform.position + new Vector3(randomX, Y, 0), transform.rotation);
            creep.SetActive(false);
            creepPool.Add(creep);
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
