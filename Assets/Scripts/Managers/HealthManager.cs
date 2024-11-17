using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthManager : Singleton<HealthManager>
{
    [SerializeField] private float maxHealthValue = 50;
    [SerializeField] public float playerHealth;
    public UnityEvent restoreHealth;
    public UnityEvent takeDamaged; 
    public void Awake()
    {
        maxHealthValue = 50;
        playerHealth = maxHealthValue;
        Debug.Log("when start ,Player health is :" + playerHealth);
    }
    public void ReduceHealth(float value)
    {
        playerHealth -= value;
        takeDamaged?.Invoke();
        Debug.Log("player current health is:" + playerHealth);
    }
    public void RestoreHealth(float value)
    {
        restoreHealth?.Invoke();
        playerHealth += value;
        Debug.Log("player current health is:" + playerHealth);
    }
}
