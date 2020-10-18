using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;
    private float horizontalMovement;
    private float verticalMovement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        SetMovementInputs();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(verticalMovement, rb.velocity.y, horizontalMovement);
    }

    void SetMovementInputs()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal") * speed;
        verticalMovement = Input.GetAxisRaw("Vertical") * speed;
    }
}
