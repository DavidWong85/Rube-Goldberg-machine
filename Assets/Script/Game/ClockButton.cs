using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClockButton : MonoBehaviour {

    public GameObject sound;
    public AudioClip audio;

    float y = 0.4f;
    bool pressed = false;

    private void Start()
    {
        sound.GetComponent<AudioSource>().clip = audio;
    }

    void OnCollisionEnter() {
        if (pressed == false)
        {
            pressed = true;
            sound.GetComponent<AudioSource>().Play();
            this.gameObject.transform.Translate(0, -y, 0);
        }
    }
}
