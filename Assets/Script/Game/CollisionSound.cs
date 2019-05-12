using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    bool collision = false;
    public GameObject sound;
    public AudioClip audio;

    private void Start()
    {
        sound.GetComponent<AudioSource>().clip = audio;
    }

    void OnCollisionEnter()
    {

        collision = true;
        sound.GetComponent<AudioSource>().clip = audio;
        sound.GetComponent<AudioSource>().Play();
    }
}

