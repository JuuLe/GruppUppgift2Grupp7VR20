using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartHit : MonoBehaviour
{
    public Rigidbody rb;

    //Ta kontroll över Rigidbody
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Stoppa pilen när den träffar tavlan
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Piltavla"))
        {
            rb.isKinematic = true;
        }
    }
}
