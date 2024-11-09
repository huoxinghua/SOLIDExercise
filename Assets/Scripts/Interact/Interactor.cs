using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<IInteractable>(out var interactableObject))
        {
             interactableObject = other.gameObject.GetComponent<IInteractable>();
            interactableObject.Interact();
        }
        else if (other.TryGetComponent<ICollectiable>(out var collectObject))
        {
            collectObject.Collect();
        }
        else if (other.TryGetComponent<IDamageable>(out var damageObject))
        {
            damageObject.TakeDamage();
        }
    }
}
