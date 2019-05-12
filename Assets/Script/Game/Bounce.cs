using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float x, y, z;
    public Rigidbody rb;

    void OnCollisionEnter(Collision ball)
    {
        rb.AddForce(0, y, z, ForceMode.Impulse);
    }
}
