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
        score = 0f;
        Debug.Log("when start ,Player collect coin is :" + score);
    }
    public void AddScore(float value)
    {
       score += value;
       addScore?.Invoke();
       Debug.Log("current score:" + score);
    }
}
