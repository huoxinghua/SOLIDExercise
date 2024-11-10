using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : Singleton<ScoreManager>
{
    public float score;
    public UnityEvent addScore;
    private void Awake()
    {
        Debug.Log("when start ,Player collect coin is :" + score);
        score = 0f;
    }
    public void AddScore(float value)
    {
       score += value;
       addScore?.Invoke();
       Debug.Log("current score:" + score);
    }
}
