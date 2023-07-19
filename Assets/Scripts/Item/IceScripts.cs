using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceScripts : MonoBehaviour,IItem
{
    private SpawnItem objectPool;

    public void Start()
    {
        objectPool = FindObjectOfType<SpawnItem>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            objectPool.RecycleItem(gameObject);

        }
        if (collision.gameObject.CompareTag("Border"))
        {
            objectPool.RecycleItem(gameObject);

        }
    }


    public void Skill()
    {
        throw new System.NotImplementedException();
    }
}
