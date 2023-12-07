using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//David
public class HG_PlayerMovement : MonoBehaviour
{

    public GameObject pause_Manager; //Simeon
    public WoPausirIch woPausirIch; //Simeon

    public Rigidbody player_Rigidbody;
    public float movespeed, jumpForce;

    private Vector2 moveInput;

    public LayerMask palyer_WhatIsGround;
    public Transform groundPoint;
    private bool isGrounded;
    

    void Start()
    {
        pause_Manager = GameObject.Find("IsAktiveManager"); //Simeon
        woPausirIch = pause_Manager.GetComponent<WoPausirIch>(); //Simeon
        Physics.gravity = new Vector3(0, -30, 0);
    }


    void Update()
    {
        woPausirIch = pause_Manager.GetComponent<WoPausirIch>(); //Simeon
        if (woPausirIch.playerIsAktive == true)
        { 
            Bewegung();
        }
       
    }
    void Bewegung()
    {
      
            moveInput.x = Input.GetAxis("Horizontal");
            moveInput.y = Input.GetAxis("Vertical");
            moveInput.Normalize();

            player_Rigidbody.velocity = new Vector3(moveInput.x * movespeed, player_Rigidbody.velocity.y, moveInput.y * movespeed);

            RaycastHit hit;

            if (Physics.Raycast(groundPoint.position, Vector3.down, out hit, 2f, palyer_WhatIsGround))
            {
                isGrounded = true;
            }
            else { isGrounded = false; }

            if (Input.GetButtonDown("Jump") && isGrounded)
            {
                player_Rigidbody.velocity += new Vector3(0f, jumpForce, 0f);
            }
        
        
    }


}

