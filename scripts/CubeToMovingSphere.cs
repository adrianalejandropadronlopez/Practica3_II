using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeToMovingSphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [Header("Velocity")]
    public float velocity = 1.0f;
    // Update is called once per frame
    void Update()
    {
        Transform sphereTransform = GameObject.Find("Sphere").transform;
        // Transform cubeTransform = this.transform;
        this.transform.LookAt(sphereTransform);
        this.transform.Translate(Vector3.forward * Time.deltaTime * velocity);
    }
}
