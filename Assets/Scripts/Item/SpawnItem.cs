using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public ItemAbstractFactory itemAbstractFactory;

    public int poolSize = 10;
    public float spawnRate = 2f;
    public float maxX;
    public float Y;
    public float minX;
    private List<GameObject> itemList;
    private List<GameObject> itemPool;
    // Start is called before the first frame update
    void Start()
    {
        itemList = new List<GameObject>();
        itemPool = new List<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject item = itemAbstractFactory.CreateItem();
            item.SetActive(false);
            itemPool.Add(item);
        }
        StartCoroutine(SpawnD());
    }


    private IEnumerator SpawnD()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);

            float randomX = Random.Range(minX, maxX);

            if (itemPool.Count > 0)
            {
                GameObject item = itemPool[0];
                item.SetActive(true);
                item.transform.position = transform.position + new Vector3(randomX, Y, 0);
                itemList.Add(item);
                itemPool.RemoveAt(0);
            }
        }
    }

    public void RecycleItem(GameObject item)
    {
        if (itemList.Remove(item))
        {
            item.SetActive(false);
            itemPool.Add(item);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
