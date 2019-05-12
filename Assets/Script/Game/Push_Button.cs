using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push_Button : MonoBehaviour
{
    public Camera_Follow other;
    public GameObject push, main;
    float y = 0.4f;
    bool pressed = false;
    bool camerachanged = false;
    private float Distance;
    private float distCovered;
    private float frac;
    private float start;
    Vector3 Target;
    public GameObject sound;
    public AudioClip audio;
    void OnCollisionEnter()
    {
        Target = push.transform.position + new Vector3(0, 0, -3);
        if (pressed == false)
        {
            sound.GetComponent<AudioSource>().Play();
            pressed = true;
            this.gameObject.transform.Translate(0, -y, 0);
            push.GetComponent<Rigidbody>().isKinematic = false;
        }
    }

    private void Start()
    {
        sound.GetComponent<AudioSource>().clip = audio;
        start = Time.time;
    }
    // Update is called once per frame
    void Update()
    {
        if (pressed == true)
        {
            if (camerachanged == false)
            {
                camerachanged = true;
                other.SetTarget(main);
            }
            distCovered = (Time.time - start) * 12;
            Distance = Vector3.Distance(push.transform.position, Target);
            frac = distCovered / Distance;
            push.transform.position = Vector3.Lerp(push.transform.position, Target, frac);
        }
        start = Time.time;
    }

    private void OnCollisionStay(Collision collision)
    {
        main.GetComponent<Rigidbody>().AddForce(0, -6, -0.02f, ForceMode.Impulse);
    }
}
