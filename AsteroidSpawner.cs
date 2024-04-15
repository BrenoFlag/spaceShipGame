
using System;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroid;
    private Vector3 v;
    private float timer;
    private int delay;
    
    void Start()
    {
        delay = 100;
        timer = 0;
    }
    
    void Update()
    {
        if (timer >= delay)
        {
            v = new Vector3(Random.Range(-51f, 51f), 33.5f, 0);
            Instantiate(asteroid, v, quaternion.identity);
            timer = 0;
            delay = Random.Range(20, 300);
        }
        else
        {
            timer += 100 * Time.deltaTime;
            Debug.Log(timer + " " + delay);
        }
    }
}
