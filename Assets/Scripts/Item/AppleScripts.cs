using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleScripts : MonoBehaviour
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
            GameObject takescore = GameObject.FindGameObjectWithTag("Player");
            takescore.transform.GetComponent<Player>().score += 5;

        }
        if (collision.gameObject.CompareTag("Border"))
        {
            objectPool.RecycleItem(gameObject);

        }
    }
 
    
}
