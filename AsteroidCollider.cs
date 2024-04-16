using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AsteroidCollider : MonoBehaviour
{
    private static int score = 0;
   
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Laser")
        {
            Destroy(gameObject);
            FindObjectOfType<ScoreScript>().incrementSCore();
            AsteroidSpawner.increaseDifficulty();
            score++;
        }
    }

    public static int getScore()
    {
        return score;
    }
}
