using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour,IDamageable
{
    [SerializeField] private float damageValue;
    public bool CanDamage {  get;  set; }
    public void GiveDamage()
    {
        HealthManager.Instance.ReduceHealth(damageValue);
    }
}
