using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [Header ("Velocity")]
    public float velocity = 1.0f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward * Time.deltaTime * velocity);
    }
}
