using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    private float movmentX;
    private float movmentY;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementValue) 
    {
    Vector2 movementVector = movementValue.Get<Vector2>();

        movmentX = movementVector.x;
        movmentY = movementVector.y;
    }

    void FixedUpdate()
    {
        Vector3 movment = new Vector3(movmentX, 0.0f, movmentY);
      
        rb.AddForce(movementVector);
    }
}
