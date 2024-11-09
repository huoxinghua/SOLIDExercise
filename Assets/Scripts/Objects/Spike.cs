using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour,IDamageable
{
    [SerializeField] private float damageValue;
    public void TakeDamage()
    {
        HealthManager.Instance.ReduceHealth(damageValue);
    }
}
