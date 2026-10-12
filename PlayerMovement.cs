using System;
using System.Data.Common;
using NUnit.Framework;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController character;
    [SerializeField] float moveSpeed = 4f;
    [SerializeField] float jumpSpeed = 3f;
    [SerializeField] float gravity = -9.81f;

    Vector3 verticalVelocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
     
        Vector3 localmoveDir = new Vector3(0f,0f,vertical).normalized;
        Vector3 worldmoveDir = transform.TransformDirection(localmoveDir);
        character.Move(worldmoveDir*moveSpeed*Time.deltaTime);

        if(Input.GetButtonDown("Jump") && character.isGrounded)
        {
            Debug.Log(character.isGrounded);
            verticalVelocity.y = jumpSpeed;
        }
        else
        {
             Debug.Log(character.isGrounded);
        }
         if(Mathf.Abs(horizontal)> 0.01)
        {
            transform.Rotate(Vector3.up,horizontal*45f*Time.deltaTime);
        }

        verticalVelocity.y += gravity*Time.deltaTime;
        character.Move(verticalVelocity*Time.deltaTime);
    

        
        
    }
}

