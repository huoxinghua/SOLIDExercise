using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour,IInteractable
{
    public void Interact()
    {
        Debug.Log("health");
    }

}
