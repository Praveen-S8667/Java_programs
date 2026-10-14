using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] Transform target;
    Vector3 followUP;
    Vector3 position =  new Vector3(0f,2.5f,-5f);
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LateUpdate()
    {
        followUP = target.TransformPoint(position);
        transform.position  = Vector3.Lerp(transform.position,followUP,45f*Time.deltaTime);
        transform.rotation = target.transform.rotation;
    }
}
