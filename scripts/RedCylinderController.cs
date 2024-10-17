using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCylinderController : MonoBehaviour
{   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private Rigidbody rb;
    public Transform sphereTransform;
    [Header("Velocity")]
    public float velocity = 1.0f;
    void FixedUpdate() {   
        if (Input.GetKey(KeyCode.T)) {
            rb.AddForce(Vector3.forward * velocity);
        } else if (Input.GetKey(KeyCode.G)) {
            rb.AddForce(Vector3.back * velocity);
        } else if (Input.GetKey(KeyCode.F)) {
            rb.AddForce(Vector3.left * velocity);  
        } else if (Input.GetKey(KeyCode.H)) {
            rb.AddForce(Vector3.right * velocity);
        } else {
            rb.MoveRotation(Quaternion.LookRotation(sphereTransform.position - transform.position));
            rb.MovePosition(transform.position + transform.forward * velocity * Time.deltaTime);
        }
    }
}
