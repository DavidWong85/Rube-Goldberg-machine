using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCountDown : MonoBehaviour {
    float timer = 0.0f;
    public int seconds;
    bool collision = false;

    void OnCollisionEnter(Collision ball)
    {
        collision = true;
    }


    void Update() {
        if (collision == true)
        {
            timer += Time.deltaTime;
            seconds = (int)(timer % 60);
            if (seconds == 3)
            {
                Object.Destroy(this.gameObject);
            }
        }
    }
}
