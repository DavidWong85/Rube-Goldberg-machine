using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Light_Button : MonoBehaviour
{
    public GameObject lightObj;
    bool collision = false;
    float timer, seconds;
    public GameObject sound;
    public AudioClip audio;

    void OnCollisionEnter()
    {
        if (collision == false)
        {
            sound.GetComponent<AudioSource>().Play();
            this.gameObject.transform.Translate(0, -0.4f, 0);
            collision = true;
            Object.Destroy(lightObj.gameObject);
        }
    }

    private void Start()
    {
        sound.GetComponent<AudioSource>().clip = audio;
    }

    private void Update()
    {
        if (collision == true)
        {
            timer += Time.deltaTime;
            seconds = (int)(timer % 60);
            if (seconds == 2)
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
