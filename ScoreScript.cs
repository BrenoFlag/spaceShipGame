using System;
using UnityEngine;
using UnityEngine.UI;

public  class ScoreScript : MonoBehaviour
{
    public Text score;
    void Start()
    {
        score.text = "0";
    }

    public void incrementSCore()
    {
        int scoreInt = Convert.ToInt32(score.text);
        scoreInt++;
        score.text = scoreInt.ToString();
    }
    
    
}
