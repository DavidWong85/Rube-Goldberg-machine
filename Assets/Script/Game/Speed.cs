using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    public GameObject mainball;
    public float y, z, x;
    // Update is called once per frame

    void OnCollisionStay(Collision ball)
    {
        mainball.GetComponent<Rigidbody>().AddForce(0, -y, z, ForceMode.Impulse);
    }
}
