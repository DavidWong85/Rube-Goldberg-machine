using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float y = 0.1f;
    public Rigidbody rb;
    public bool start = false;
    public object gate;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (start == false)
        {
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(0, 0, -y, ForceMode.Impulse);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(0, 0, y, ForceMode.Impulse);
            }
        }
    }
    void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.name == "Start Gate")
        {
            start = true;
        }
    }
}
