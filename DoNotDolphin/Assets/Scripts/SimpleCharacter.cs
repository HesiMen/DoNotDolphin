﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SimpleCharacter : MonoBehaviour
{
    CharacterController controller;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {

            // We are grounded, so recalculate
            // move direction directly from axes

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

            moveDirection = Camera.main.transform.TransformDirection(moveDirection); moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }


        moveDirection.y -= gravity * Time.deltaTime;


        controller.Move(moveDirection * Time.deltaTime);
    }
}