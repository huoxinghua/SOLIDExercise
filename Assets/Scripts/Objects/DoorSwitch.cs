using UnityEngine;

public class DoorSwitch : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject doorPivot;
    public float rotationAngle = 90f; // Angle to rotate the door
    public float rotationDuration = 1f; // Time in seconds for the rotation

    private Quaternion initialRotation;
    private Quaternion targetRotation;
    private bool isRotating = false;
    private float rotationTime = 0f;
    
    void Start()
    {
        initialRotation = doorPivot.transform.rotation;
        targetRotation = Quaternion.Euler(0, rotationAngle, 0) * initialRotation;
    }

    public void Interact()
    {
            OpenDoor();
    }

    public void OpenDoor()
    {
        if (!isRotating)
        {
            isRotating = true;
            rotationTime = 0f;
        }

    }

    void FixedUpdate()
    {
        if (isRotating)
        {
            rotationTime += Time.fixedDeltaTime / rotationDuration;
            doorPivot.transform.rotation = Quaternion.Lerp(initialRotation, targetRotation, rotationTime);
            initialRotation = targetRotation;
            if (rotationTime >= 1f)
            {
                isRotating = false;
            }
        }

    }

}

