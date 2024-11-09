using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : Singleton<ScoreManager>
{
    private float score = 0f;
    
    public void AddScore(float value)
    {
       score += value;
       Debug.Log("current score:" + score);
    }
        

}
