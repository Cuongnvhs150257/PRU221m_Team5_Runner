using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ItemEffect/PowerBuff")]
public class PowerBuff : ItemEffect
{
    public bool heart;
    public bool shield;
    public bool ice;

    Time time;

    public override void Activate(GameObject target)
    {
        if (heart)
        {
            Debug.Log("Health ++");          

            GameObject player = GameObject.FindGameObjectWithTag("Player");
            var healthcurrent = player.transform.GetComponent<HealthManager>().health;
            if (healthcurrent < 3)
            {
                player.transform.GetComponent<HealthManager>().health = healthcurrent + 1;
            }

        }
        else if (shield)
        {
            Debug.Log("Shield Activated");
            GameObject takedame = GameObject.FindGameObjectWithTag("Player");
            takedame.transform.GetComponent<HealthManager>().isShield = true;
            
        }
        else
        {
            Debug.Log("Ice Activated");
            GameObject gameManager = GameObject.FindGameObjectWithTag("gameManager");
            gameManager.GetComponent<CameraMovement>().CameraSpeed = 6f;
            GameObject spawnPoint = GameObject.FindGameObjectWithTag("spawnPoint");
            spawnPoint.GetComponent<SpawnManager>().spawnRate = 2f;




        }

    }

}