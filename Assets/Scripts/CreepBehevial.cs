using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreepBehevial : MonoBehaviour
{
    private SpawnCreep objectPool;

    private void Start()
    {
        objectPool = FindObjectOfType<SpawnCreep>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            objectPool.RecycleCreep(gameObject);
        }
        if (collision.gameObject.CompareTag("Border"))
        {
            objectPool.RecycleCreep(gameObject);

            GameObject takedame = GameObject.FindGameObjectWithTag("Player");

            takedame.transform.GetComponent<Player>().score += 1;
        }
        
    }
}
