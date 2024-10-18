using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereModi : MonoBehaviour {       
    private Rigidbody rb;
    [Header("Velocity")]
    public float velocity = 1.0f;

    // Código reciclado de ColissionWithTrigger.cs
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name != "Plane") {
            Debug.Log("Colision con: " + other.gameObject.name);
            if (other.gameObject.tag == "Capsule") {
                GetComponent<Renderer>().material.color = Color.green;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    // Código reciclado de SphereControllerPhysics.cs
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.I)) {
            rb.AddForce(Vector3.forward * velocity);
        } else if (Input.GetKey(KeyCode.K)) {
            rb.AddForce(Vector3.back * velocity);
        } else if (Input.GetKey(KeyCode.J)) {
            rb.AddForce(Vector3.left * velocity);
        } else if (Input.GetKey(KeyCode.L)) {
            rb.AddForce(Vector3.right * velocity);
        }
    }
}
