using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTarget : MonoBehaviour
{
    Rigidbody rb;

    Vector2 moveDirection = Vector2.zero;
    Vector3 appliedMovement = Vector3.zero;

    const float moveSpeed = 9f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveDirection.Normalize();

        appliedMovement.x = moveDirection.x * moveSpeed;
        appliedMovement.z = moveDirection.y * moveSpeed;
    }
    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + appliedMovement * Time.fixedDeltaTime);
    }
}
