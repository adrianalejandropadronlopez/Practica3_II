using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColissionWithTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        Debug.Log("Colision con: " + other.gameObject.name);
    }
}
