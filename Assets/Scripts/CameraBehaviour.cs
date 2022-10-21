using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public float speed = 5;
    
    public List<Vector3> cameraAngles = new List<Vector3>(5);
    int prevCameraAngle = 0;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            transform.eulerAngles += speed * new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);
            Debug.Log("X: " + Input.GetAxis("Mouse X"));
            Debug.Log("Y: " + Input.GetAxis("Mouse Y"));
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.position -= cameraAngles[prevCameraAngle];
            transform.position += cameraAngles[0];
            prevCameraAngle = 0;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.position -= cameraAngles[prevCameraAngle];
            transform.position += cameraAngles[1];
            prevCameraAngle = 1;
        }


        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            transform.position -= cameraAngles[prevCameraAngle];
            transform.position += cameraAngles[2];
            prevCameraAngle = 2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            transform.position -= cameraAngles[prevCameraAngle];
            transform.position += cameraAngles[3];
            prevCameraAngle = 3;
        }
    }
}
