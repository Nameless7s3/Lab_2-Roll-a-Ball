using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Input : MonoBehaviour
{
    [Header("Controls")]
    [SerializeField] Player playerControls;
    public InputAction move;

    #region toggle player controls
    private void OnEnable()
    {
        move = playerControls.Movement.move;
        playerControls.Enable();
    }
    private void OnDisable()
    {
        move.Disable();
    }
    #endregion

    private void Awake()
    {
        playerControls = new Player();
    }
}