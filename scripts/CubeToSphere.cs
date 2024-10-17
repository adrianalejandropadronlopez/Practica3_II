using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CubeToSphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [Header("Velocity")]
    public float velocity = 1.0f;
    // Update is called once per frame
    void Update() {
        Transform sphereTransform = GameObject.Find("Sphere").transform;
        Transform cubeTransform = this.transform;
        Vector3 direction = sphereTransform.position - cubeTransform.position;
        direction = direction.normalized;
        transform.Translate(direction * Time.deltaTime * velocity);
    }
}
