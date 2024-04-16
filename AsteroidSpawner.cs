using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroid;
    private Vector3 v;
    private float timer;
    private float delay;
    private static float minDelay;
    private static float maxDelay;
    private static bool increase;
    private static int difficulty;
    void Start()
    {
        delay = 5f;
        timer = 0;
        minDelay = 2f;
        maxDelay = 5f;
        increase = false;
        difficulty = 1;
    }
    
    void Update()
    {
        spawn();
    }

    public static void increaseDifficulty()
    //Only needs to be called when score is increased, therefore is being called inside of AsteroidCollider.OnCollisionEnter()
    //in every score multiply of 5, decreases the minDelay and maxDelay, making objects spawn faster, increasing difficulty
    {
        if (AsteroidCollider.getScore() > 1 & AsteroidCollider.getScore() == 5*difficulty-1)
        {
            increase = true;
        }

        if (increase & AsteroidCollider.getScore() % 5 == 0)
        {
            increase = false;
            difficulty++;
            
            if (minDelay > 0.5f)
            {
                minDelay -= 0.25f;
            }
            else if (minDelay > 0.1)
            {
                minDelay -= 0.02f;
            }

            if (maxDelay > 2)
            {
                maxDelay -= 0.5f;
            }
            else if(maxDelay > 0.5f)
            {
                maxDelay -= 0.075f;
            }
            
        }
    }

    void spawn()
    {
        // responsible for spawning new asteroids, with a randomly generated delay time withing set ranges
        if (timer >= delay)
        {
            v = new Vector3(Random.Range(-51f, 51f), 33.5f, 0);
            Instantiate(asteroid, v, quaternion.identity);
            timer = 0;
            delay = Random.Range(minDelay, maxDelay);
        }
        else
        {
            //add 1 to timer per second
            timer += Time.deltaTime;
        }
    }
}
