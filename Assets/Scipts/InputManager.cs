using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Game.Scripts.Player;
using Game.Scripts.LiveObjects;
using Game.Scripts.UI;

public class InputManager : MonoBehaviour
{
    private PlayerInputActions _input;
    [SerializeField]
    private Player _player;
    private Crate _crate;
    

    // Start is called before the first frame update
    void Start()
    {
        InitializeInputs();
    }

    // Update is called once per frame
    void Update()
    {
        var move = _input.Player.Walk.ReadValue<Vector2>();
        // _player.PlayerMovement(move);
        _player.SetMove(move);
    }

    void InitializeInputs()
    {
        _input = new PlayerInputActions();
        _input.Player.Enable();
        _input.Crate.Enable();
    }
}