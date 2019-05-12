using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour 
{
	public GameObject main;
	public Vector3 Position;

    public int follow = 1;
    public Transform target;
    private float Distance;
    private float distCovered;
    private float frac;
    private float starttime;

    public void SetTarget(GameObject x)
    {
        target = x.transform;
    }

    private void Start()
    {
        target = main.transform;
        starttime = Time.time;
    }

    // Update is called once per frame
    void Update () 
	{
        distCovered = (Time.time - starttime) * 50;
        Distance = Vector3.Distance(this.transform.position, target.transform.position);
        frac = distCovered / Distance;
        starttime = Time.time;
        transform.position = Vector3.Lerp(this.transform.position, target.transform.position + Position, frac);
    }
}
