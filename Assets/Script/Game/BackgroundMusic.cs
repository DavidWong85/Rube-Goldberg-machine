using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioClip BGM, alarm;
    public GameObject camera;
    bool collision = false;

    public void Start()
    {
        camera.GetComponent<AudioSource>().clip = alarm;
        camera.GetComponent<AudioSource>().Play();
    }
    public void OnCollisionEnter()
    {
        if (collision == false)
        {
            collision = true;
            camera.GetComponent<AudioSource>().clip = BGM;
            camera.GetComponent<AudioSource>().Play();
        }
    }
}
