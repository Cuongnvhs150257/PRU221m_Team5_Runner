using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float CameraSpeed;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(CameraSpeed * Time.deltaTime, 0, 0);
        checkIce();
    }

    public void checkIce()
    {
        if (CameraSpeed < 12)
        {
            StartCoroutine(ResetSpeed());
        }
    }
    public IEnumerator ResetSpeed()
    {
        yield return new WaitForSeconds(5f);
        CameraSpeed = 12;
        Debug.Log("Shield deActivated");
    }
}
