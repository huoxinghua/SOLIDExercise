using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float playerSpeed = 2f;
    private float horizontal;
    private float vertical;
    void Update()
    {
        HandleMove();
    }
    private void HandleMove()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;
        if (direction.magnitude >= 0.1f)
        {
            transform.Translate(direction * playerSpeed * Time.deltaTime, Space.World);
        }
    }
}