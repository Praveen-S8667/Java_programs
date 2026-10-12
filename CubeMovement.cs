using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class CubeMovement : MonoBehaviour
{
    [SerializeField] float cubeSpeed= 5.0f;
    [SerializeField] float rotationSpeed= 45f;
    private float horizontal;
    private float vertical;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Debug.Log(horizontal);
          
        if(Mathf.Abs(horizontal)> 0.01)
        {
            transform.Rotate(Vector3.up,horizontal*rotationSpeed*Time.deltaTime);
            // Quaternion target = Quaternion.LookRotation(Vector3.right*horizontal);
            // Quaternion rotation = Quaternion.RotateTowards(transform.rotation,target,rotationSpeed*Time.deltaTime);
            // transform.rotation = rotation;
        }
      
      
        Vector3 normalizedDirection = new Vector3(0f,0f,vertical).normalized;
        transform.Translate(normalizedDirection*cubeSpeed*Time.deltaTime);
    }

    
}

// rb=GetComponent<Rigidbody>();
        //  transform.rotation = Quaternion.Euler(40f,45f,0f);
// private Vector2 moveInput;
    // private Rigidbody rb;

  // if(Mathf.Abs(horizontal)> 0.01)
        // {
        //     transform.rotation = Quaternion.RotateTowards(transform.rotation,Quaternion.LookRotation(Vector3.right*horizontal), 45*Time.deltaTime);
        // }

    // Vector3 target = Vector3.down;
            // Quaternion targetRotation = Quaternion.FromToRotation(transform.forward, target);
            // transform.rotation = targetRotation;
            // Quaternion target = Quaternion.LookRotation(Vector3.up);
            // Quaternion towards = Quaternion.RotateTowards(transform.rotation,target,45f*Time.deltaTime);
            // transform.rotation = towards;
            // Vector3 customAxis = new Vector3(0f,1f,0f).normalized;
            // Quaternion rotations = Quaternion.AngleAxis(45f,customAxis);
            // transform.rotation = Quaternion.RotateTowards(transform.rotation,rotations,45f*Time.deltaTime);
            // transform.Rotate(0f,90f*Time.deltaTime,0f,Space.Self);
            // Quaternion target = Quaternion.LookRotation(Vector3.forward);
            // transform.rotation = Quaternion.RotateTowards(transform.rotation,target,45f*Time.deltaTime);
 
    // Vector2 normalizeDirection = moveInput.normalized;
    // rb.linearVelocity= new Vector3(normalizeDirection.x*cubeSpeed,rb.linearVelocity.y,normalizeDirection.y*cubeSpeed);

    // public void OnMove(InputAction.CallbackContext context)
    // {
    //     if (context.performed)
    //     {
    //         Debug.Log("Move action performed");
    //         moveInput = context.ReadValue<Vector2>();
    //         Debug.Log(moveInput);
            
    //     }
    //     if (context.canceled)
    //     {
    //         moveInput = Vector2.zero;
    //         Debug.Log("Move action released");
    //     }
    // }
