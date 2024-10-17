using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMultiplication : MonoBehaviour
{

    [Header("Velocity")]
    public float velocity = 1.0f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("The key UpArrow was pressed: " + Input.GetAxis("Vertical") * velocity);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("The key DownArrow was pressed: " + Input.GetAxis("Vertical") * velocity);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("The key LeftArrow was pressed: " + Input.GetAxis("Horizontal") * velocity);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("The key RightArrow was pressed: " + Input.GetAxis("Horizontal") * velocity);
        }
    }
}
