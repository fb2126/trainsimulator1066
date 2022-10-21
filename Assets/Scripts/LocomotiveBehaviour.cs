using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocomotiveBehaviour : MonoBehaviour
{
    [SerializeField]
    public float throttleIncrement = 10;

    int currentThrottle = 0;

    Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            if (currentThrottle < 5) currentThrottle++;

        if (Input.GetKeyDown(KeyCode.S))
            if (currentThrottle > 0) currentThrottle--;
        //Debug.Log("Current throttle "+ currentThrottle);
        //Debug.Log("Velocity" + rigidBody.velocity);
        
        rigidBody.AddForce(new Vector3(-1, 0, 0) * (currentThrottle * throttleIncrement), ForceMode.Acceleration);
    }
}
