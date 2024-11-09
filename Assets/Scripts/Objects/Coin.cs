using UnityEngine;

public class Coin : MonoBehaviour, ICollectiable
{
    [SerializeField] private float scoreValue =2f;
    public void Collect()
    {
        ScoreManager.Instance.AddScore(scoreValue);
        Destroy(gameObject);
    }
}
