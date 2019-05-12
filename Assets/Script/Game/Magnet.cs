using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour {

    public GameObject metal;
    public float distance;
    bool activated = true;
    public Vector3 force;
    public float magtimer, magseconds;
    bool Collision = false;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (activated == true)
        {
            distance = Vector3.Distance(this.gameObject.transform.position, metal.transform.position);
            force = (this.gameObject.transform.position - metal.transform.position);
            if (distance < 3.0f)
            {
                metal.GetComponent<Rigidbody>().AddForce(force / distance, ForceMode.Impulse);
            }
        }

        if (Collision == true)
        {
            magtimer += Time.deltaTime;
            magseconds = (int)(magtimer % 60);

            if (magseconds > 5)
            {
                this.transform.Translate(0, 0, 3.6f * Time.deltaTime);
            }

            if (magseconds == 8)
            {
                activated = false;
                Collision = false;
            }
        }
	}

    void OnCollisionEnter()
    {
        if (Collision == false)
        {
            Collision = true;
        }
    }


}
