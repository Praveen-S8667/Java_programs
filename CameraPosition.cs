using UnityEngine;
using UnityEngine.InputSystem;

public class CameraPosition : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] Transform target;
    [SerializeField] float speed = 45f;
    public float dis=10;
    Vector3 position = new Vector3(0f,2.16f,-10f);
    float mouseXposition;
    float mouseYposition;
    bool mouseClicked  = false;

    // Vector3 position;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void LateUpdate()
    {
        
        Vector3 followup = target.TransformPoint(position);
        followup.y = transform.position.y;
        transform.position = Vector3.Lerp(transform.position,followup,speed*Time.deltaTime);
        Vector3 dir = (transform.position-target.position).normalized;

        mouseXposition = Input.GetAxisRaw("Mouse X");
        mouseYposition = Input.GetAxisRaw("Mouse Y");
        if(Input.GetMouseButtonDown(0))
        {
            mouseClicked = true;
            Debug.Log("mouse clicked true");
        }
        else if(Input.GetMouseButtonUp(0))
        {
            mouseClicked = false;
            Debug.Log("mouse clicked false");
        }
        Debug.Log($"mouse xposition : {mouseXposition}");
        Debug.Log($"mouse yposition : {mouseYposition}");
        if (mouseClicked)
        {
            transform.RotateAround(target.position,new Vector3(0,1,0), mouseXposition*300f*Time.deltaTime);
        }
        

       
        // if (!mouseClicked)
        // {
        //     transform.rotation = Quaternion.Slerp(transform.rotation,target.rotation,speed*Time.deltaTime);
        // }

        
    }
}
