using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    bool CanDamage { get; set; }

    public void GiveDamage()
    {
        Debug.Log("take damage");
    }
}
