using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] float walkSpeed = 1.5f;
    [SerializeField] float runningSpeed = 3f;
    CharacterController controller;
    Animator animator;
    float horizontal;
    float vertical;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        // speed = ;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(0f,0f,vertical).normalized;
        Vector3 localdirection = transform.TransformDirection(direction);
        Debug.Log($"the direction magnitude is {direction.magnitude}");
        bool isRunning = Input.GetKey(KeyCode.LeftShift);
        float targetSpeed = direction.magnitude*vertical*(isRunning ? runningSpeed : walkSpeed);
        Debug.Log($" the direcion + vertical  {direction*vertical}");
        Debug.Log($"the target speed is  {targetSpeed}");
        animator.SetFloat("speed",targetSpeed);
        controller.Move(localdirection * targetSpeed * Time.deltaTime);

        if (Mathf.Abs(horizontal) > 0)
        {
            transform.Rotate(Vector3.up,horizontal*45f*Time.deltaTime);
        }
        
    }
}
