using UnityEngine;

public class CoinUpgrade : Coin
{
    [SerializeField] private float healthIncreaseAmount = 2f;
    public override void Collect()
    {
        HealthManager.Instance.RestoreHealth(healthIncreaseAmount);
        base.Collect();

    }
}
