using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerInput))]
public class RunTimeMovement : MonoBehaviour
{
    private Movement input;
    private CharacterController _controller;
    [SerializeField] private float fraction;
    private Animator _anim;
    void Start()
    {
        input = GetComponent<Movement>();
        _controller = GetComponent<CharacterController>();
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Motion();
        
        
    }

    private void Motion()
    {
        _controller.Move(new Vector3((input.moveVal.x * input.moveSpeed)/fraction, 0f, (input.moveVal.y * input.moveSpeed)/fraction));
        _anim.SetFloat("walk_f",Mathf.Abs(_controller.velocity.x) +Mathf.Abs(_controller.velocity.z));
    }
}
