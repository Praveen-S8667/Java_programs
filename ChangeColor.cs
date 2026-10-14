using Unity.VisualScripting;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // [SerializeField] Transform player;
    [SerializeField] Transform target;

    [SerializeField] float moveSpeed = 4f;
    Renderer render;
    float horizontal;
    float vertical;

    CharacterController controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>();
        render = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal,0f,vertical).normalized;
        controller.Move(direction*moveSpeed*Time.deltaTime);

        
        Vector3 targetDirection = (transform.position-target.transform.position).normalized;
        float forntRear = Vector3.Dot(transform.forward,targetDirection);

        if (forntRear > 0)
        {
            render.material.color = Color.blue;
        }
        else
        {
            render.material.color = Color.green;
        }

    }
}
