using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour {
    public GameObject obj1, obj2, ball;
    bool collision = false;
	float eletimer = 0.0f;
	public int eleseconds = 0;
    bool door1closed = false;
    public int height = 0;
    bool elestart = false;
    public float y, thrust, z;
    public Rigidbody rb;
    void OnCollisionEnter(Collision ball)
    {
		collision = true;
    }
	void FixedUpdate()
	{
		if (collision == true) 
		{
			eletimer += Time.deltaTime;
			eleseconds = (int)(eletimer % 60);
            if (eleseconds == 1 && door1closed == false)
			{
                door1closed = true;
				obj1.transform.Translate (1, 0, 0);
			}
            if (eleseconds == 3 && door1closed == true && elestart == false)
            {
                elestart = true;
            }
            if (door1closed == true && elestart == true && eleseconds < 19)
            {
                this.transform.Translate(Vector3.up * Time.deltaTime);
                obj1.transform.Translate(Vector3.up * Time.deltaTime);
                obj2.transform.Translate(Vector3.up * Time.deltaTime);
                ball.transform.Translate(Vector3.up * Time.deltaTime);
            }
            if (door1closed == true && elestart == true && eleseconds == 21)
            {
                rb.AddForce(0, 0, -z, ForceMode.Impulse);
            }
            if (door1closed == true && elestart == true && eleseconds == 22)
            {
                elestart = false;
                obj2.transform.Translate(-1, 0, 0);
            }
            if (eleseconds == 23)
            {
                rb.AddForce(0, y, thrust, ForceMode.Impulse);
            }

		}
	}
}
