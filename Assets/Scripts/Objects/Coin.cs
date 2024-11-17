using UnityEngine;

public class Coin : MonoBehaviour, ICollectiable
{
    [SerializeField] protected float scoreValue =1f;
  
    public virtual void Collect()
    {
        ScoreManager.Instance.AddScore(scoreValue);
        Destroy(gameObject);
    }
}
