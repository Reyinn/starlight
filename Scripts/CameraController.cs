using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float damping;

    private Vector3 velocity = Vector3.zero;
  
    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
        

    }
    void FixedUpdate()
        {
            Vector3 movePosition = target.position + offset;
            transform.position = Vector3.SmoothDamp(transform.position, movePosition, ref velocity, damping);
        }
    
    void Update()
    {
        //Camera Zoom Function
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (cam.orthographicSize > 3)
            {
                cam.orthographicSize -= 1;
            }

        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (cam.orthographicSize < 13)
            {
                cam.orthographicSize += 1;
            }
        }

      
    }

    

    

    


}
