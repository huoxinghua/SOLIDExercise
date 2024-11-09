using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : Singleton<HealthManager>
{
    [SerializeField] private float maxHealthValue = 50;
    [SerializeField] private float playerHealth;

    private void Start()
    {
        playerHealth = maxHealthValue;
        Debug.Log("when start ,Player health is :" + playerHealth);
    }
    public void ReduceHealth(float value)
    {
        playerHealth -= value;
        Debug.Log("player current health is:" + playerHealth);
    }
    public void RestoreHealth(float value)
    {
        playerHealth += value;
        Debug.Log("player current health is:" + playerHealth);
    }
}
