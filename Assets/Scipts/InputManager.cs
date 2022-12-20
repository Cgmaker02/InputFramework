using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Game.Scripts.Player;

public class InputManager : MonoBehaviour
{
    private PlayerInputActions _input;
    [SerializeField]
    private Player _player;

    // Start is called before the first frame update
    void Start()
    {
        InitializeInputs();
    }

    // Update is called once per frame
    void Update()
    {
        var move = _input.Player.Walk.ReadValue<Vector3>();
        _player.PlayerMovement(move);
    }

    void InitializeInputs()
    {
        _input = new PlayerInputActions();
        _input.Player.Enable();
    }
}
