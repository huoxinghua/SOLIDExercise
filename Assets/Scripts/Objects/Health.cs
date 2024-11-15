using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour,ICollectiable
{
    [SerializeField] private float healthIncreaseAmount;
    public void Collect()
    {
       HealthManager.Instance.RestoreHealth(healthIncreaseAmount);
       Destroy(gameObject);
    }

}
