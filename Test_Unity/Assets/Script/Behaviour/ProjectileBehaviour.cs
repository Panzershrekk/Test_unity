using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ProjectileBehaviour : MonoBehaviour
{
	public ProjectileStats stats;
	public Vector3 dest;
	public Color[] weatherColor;
	
	private Camera cam;
	private SettingsAndStatsManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
		cam = GameObject.FindWithTag("Camera").GetComponent<Camera>();
		dest = cam.transform.forward;
		gameManager = GameObject.FindWithTag("GameManager").GetComponent<SettingsAndStatsManager>();
		
		Renderer rend = GetComponent<Renderer>();
        rend.material.color = weatherColor[gameManager.GetComponent<Weather>().weatherState];
    }

    // Update is called once per frame
    void Update()
    {
		transform.position = transform.position + dest * stats.speed * Time.deltaTime;
    }
}
