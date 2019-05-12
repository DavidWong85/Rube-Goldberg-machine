using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class domino : MonoBehaviour
{
    public Camera_Follow other;
    bool touched = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "domino" || gameObject.tag == "ball")
        {
            if (touched == false)
            {
                touched = true;
                other.SetTarget(this.gameObject);
            }
        }
    }
}
