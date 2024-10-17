using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColissionWith : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        Debug.Log("Colision con: " + other.gameObject.name);
    }
}
