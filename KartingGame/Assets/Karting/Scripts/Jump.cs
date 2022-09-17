using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    // Make Cart Jump
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("inside");
            other.attachedRigidbody.AddForce(Vector3.up*100000f);
        }
    }
}
