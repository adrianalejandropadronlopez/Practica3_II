using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControllerPhysics : MonoBehaviour
{
    private Rigidbody rb;
    [Header("Velocity")]
    public float velocity = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            rb.AddForce(Vector3.forward * velocity);
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            rb.AddForce(Vector3.back * velocity);
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            rb.AddForce(Vector3.left * velocity);
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            rb.AddForce(Vector3.right * velocity);
        }
    }
}
