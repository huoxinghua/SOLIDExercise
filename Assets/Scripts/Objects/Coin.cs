using UnityEngine;

public class Coin : MonoBehaviour, ICollectiable
{
    public void Collect()
    {
        Debug.Log("get coin");
        Destroy(gameObject);
    }
}
