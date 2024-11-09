using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour,IInteractable
{
    [SerializeField] private float healthIncreaseAmount;
    public void Interact()
    {
       HealthManager.Instance.RestoreHealth(healthIncreaseAmount);
    }

}
