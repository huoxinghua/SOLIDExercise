using UnityEngine;

public class DoorSwitch : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject door;
    void Start()
    {

    }

    // Update is called once per frame
    public void Interact()
    {
       
        OpenDoor();
    }

    private void OpenDoor()
    {
        Debug.Log("open the door");
    }
}
