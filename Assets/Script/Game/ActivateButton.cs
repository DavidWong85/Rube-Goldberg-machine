using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateButton : MonoBehaviour {
    public Camera_Follow other;
    float y = 0.4f;
    bool pressed = false;
    public float timer, seconds;
    bool camerachanged = false;
    public GameObject metal;
    public GameObject sound;
    public AudioClip audio;

    void OnCollisionEnter()
    {
        if (pressed == false)
        {
            sound.GetComponent<AudioSource>().Play();
            this.gameObject.transform.Translate(0, 0, y);
            pressed = true;
        }
    }
    private void Start()
    {
        sound.GetComponent<AudioSource>().clip = audio;
    }
    void Update()
    {
        if (pressed == true)
        {
            if (camerachanged == false)
            {
                camerachanged = true;
                other.SetTarget(metal);
            }
        }
    }
}
