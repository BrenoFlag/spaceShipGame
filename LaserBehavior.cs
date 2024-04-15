using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBehavior : MonoBehaviour
{
    private bool destroy = false;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * (50 * Time.deltaTime);
        if (transform.position.y > 31)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}
