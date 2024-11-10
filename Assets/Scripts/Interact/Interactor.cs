using UnityEngine;

public class Interactor : MonoBehaviour
{
    private IInteractable interactableObject = null;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<IInteractable>() != null)
        {
            interactableObject = other.gameObject.GetComponent<IInteractable>();
            ShowInteractKey();
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

    void Update()
    {
        InteractWithInput();
    }

    private void InteractWithInput()
    {
        if (interactableObject != null && Input.GetKeyDown(KeyCode.E))
        {
            interactableObject.Interact();
        }

    }
    private void ShowInteractKey()
    {
        Debug.Log("Press E to interact");
    }
}
