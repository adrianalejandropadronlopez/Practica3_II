using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCylinder : MonoBehaviour {
    private Rigidbody rb;
    [Header ("Destination")]
    public Vector3 destination;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        destination = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.T)) {
            rb.MovePosition(destination);
        }
    }
}
