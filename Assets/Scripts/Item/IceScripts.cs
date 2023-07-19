using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceScripts : MonoBehaviour
{
    public ItemEffect itemEffect;
    private SpawnItem objectPool;

    public void Start()
    {
        objectPool = FindObjectOfType<SpawnItem>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("aaaa");
            objectPool.RecycleItem(gameObject);
            itemEffect.Activate(collision.gameObject);

        }
        if (collision.gameObject.CompareTag("Border"))
        {
            objectPool.RecycleItem(gameObject);

        }
    }
 
}
