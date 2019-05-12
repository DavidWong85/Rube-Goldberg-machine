using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnHit : MonoBehaviour
{
    public GameObject sound;
    public AudioClip audio;
    void Start()
    {
        sound.GetComponent<AudioSource>().playOnAwake = false;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Metal Ball")
        {
            sound.GetComponent<AudioSource>().clip = audio;
            sound.GetComponent<AudioSource>().Play();
        }
    }
}
