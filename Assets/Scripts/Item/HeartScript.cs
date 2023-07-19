using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour,IItem
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
            GameObject health = GameObject.FindGameObjectWithTag("Player");
            var healthcurrent = health.transform.GetComponent<HealthManager>().health;
            if (healthcurrent < 3)
            {
                health.transform.GetComponent<HealthManager>().health = healthcurrent + 1;
            }


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
