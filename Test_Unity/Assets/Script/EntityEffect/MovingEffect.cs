using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class MovingEffect : MonoBehaviour {

    public float degreesPerSecond = 15.0f;
    public float amplitude = 0.5f;
    public float frequency = 1f;
	public bool xAxis = false;
	public bool yAxis = false;
	public bool zAxis = false;
 
    private Vector3 posOffset = new Vector3 ();
    private Vector3 tempPos = new Vector3 ();
 
    void Start () {
        posOffset = transform.position;
    }
     
    void Update () {
        transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSecond, 0f), Space.World);
 
        tempPos = posOffset;
		if (xAxis)
			tempPos.x += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;
		if (yAxis)
			tempPos.y += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;
		if (zAxis)
			tempPos.z += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;
        transform.position = tempPos;
    }
}