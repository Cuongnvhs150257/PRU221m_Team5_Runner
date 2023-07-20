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

            GameObject takedame = GameObject.FindGameObjectWithTag("Player");
         

            var healthcurrent = takedame.transform.GetComponent<HealthManager>().health;

            takedame.transform.GetComponent<HealthManager>().health = healthcurrent - 1;

        }
        if (collision.gameObject.CompareTag("Border"))
        {
            objectPool.RecycleCreep(gameObject);

            
        }

        Attack();
    }

    public void Attack()
    {
       
    }
}



