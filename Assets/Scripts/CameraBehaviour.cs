using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            transform.eulerAngles += speed * new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);
            Debug.Log("X: " + Input.GetAxis("Mouse X"));
            Debug.Log("Y: " + Input.GetAxis("Mouse Y"));
            
        }
        
    }

}
