using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Controller : MonoBehaviour
{
    Player_Input playerControls;

    [Header("Physics")]
    [SerializeField] Rigidbody rb;
    [SerializeField] Vector3 moveDirection;
    [SerializeField] float moveSpeed;

    private void Start()
    {
        playerControls = GetComponent<Player_Input>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        LinkInputsToVariables();
    }
    void FixedUpdate()
    {
        ApplyMovement();
    }

    void ApplyMovement()
    {
        rb.AddForce(moveDirection * moveSpeed, ForceMode.Acceleration);
    }

    void LinkInputsToVariables()
    {
        moveDirection = playerControls.move.ReadValue<Vector3>();
    }
}
