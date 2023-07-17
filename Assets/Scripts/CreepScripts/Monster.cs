using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour, IAnimal
{
    private SpawnManager objectPool;

    public void Start()
    {
        objectPool = FindObjectOfType<SpawnManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            objectPool.RecycleCreep(gameObject);
            
        }
        Attack();
    }

    public void Attack()
    {
        Debug.Log("Monster attacks!");
    }
}



