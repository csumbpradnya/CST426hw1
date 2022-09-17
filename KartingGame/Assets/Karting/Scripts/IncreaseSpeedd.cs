using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSpeedd : MonoBehaviour
{
    // Increase kart speed
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("I AM SPEEED");
            other.attachedRigidbody.AddForce(new Vector3(0f,0f ,100000f ));
        }
    }
}
