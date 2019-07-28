using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitingEffect : MonoBehaviour
{
    public float orbitRange = 1.0f;
	public float speed = 1.0f;
    // Update is called once per frame
    void Update () 
	{
        transform.position = transform.parent.position + (transform.position - transform.parent.position).normalized * orbitRange;
        transform.RotateAround(transform.parent.position, new Vector3(0, 0, 1), speed * Time.deltaTime);
    }
}