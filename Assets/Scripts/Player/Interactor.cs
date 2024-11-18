using UnityEngine;

public class Interactor : MonoBehaviour
{
    private IInteractable interactableObject;
    private IDamageable damageableObject;
    [SerializeField] GameObject hintText;
    private void Start()
    {
        hintText.SetActive(false);
    }
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

            if(damageableObject !=null && damageableObject.CanDamage == true)
            {
                return;
            }
            damageableObject = damageObject;

            damageableObject.CanDamage = true;
            damageObject.GiveDamage();
    
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (damageableObject != null)
        {
            damageableObject.CanDamage=false;
            damageableObject = null;
        }
        if (interactableObject != null)
        {
            hintText.SetActive(false);
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
        hintText.SetActive(true);
        Debug.Log("Press E to interact");
    }
}
