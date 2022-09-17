using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    // Jump
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            Debug.Log(other.transform.position);
            other.attachedRigidbody.transform.position = new Vector3(-44f,12f , 57f);
            Debug.Log("Teleportation Successful");
        }
    }
}

    
