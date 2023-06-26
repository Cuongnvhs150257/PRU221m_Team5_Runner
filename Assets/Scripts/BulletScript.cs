using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject firePoint;
    private float xBullet;
    void Start()
    {
        gameObject.transform.position = firePoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject firePoint2 = GameObject.FindGameObjectWithTag("Player");
        gameObject.transform.position = new Vector2 ((xBullet*Time.deltaTime ), firePoint.transform.position.y);
    }
}
