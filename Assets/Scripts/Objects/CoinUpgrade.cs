using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinUpgrade : Coin
{
    [SerializeField] private float healthIncreaseAmount;
    public override void Collect()
    {
        ScoreManager.Instance.AddScore(base.scoreValue);
        HealthManager.Instance.RestoreHealth(healthIncreaseAmount);
        Destroy(gameObject);
       
    }
}
