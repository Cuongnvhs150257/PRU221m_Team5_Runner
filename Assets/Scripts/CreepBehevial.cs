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

        if (collision.tag == "Border")
        {
            objectPool.RecycleCreep(gameObject);
        }
        if (collision.tag == "Player")
        {

            objectPool.RecycleCreep(gameObject);
        }
    }
}
