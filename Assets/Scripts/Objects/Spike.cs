using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour,IDamageable
{
    public void TakeDamage()
    {
        Debug.Log("take damage");
    }
}
