using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class PlaceOnTouch : MonoBehaviour
{
	private ARRaycastManager raycastManager;
	private List<ARRaycastHit> hits;
	private SettingsAndStatsManager gameManager;
	
	public GameObject[] placedObject;
	
    // Start is called before the first frame update
    void Start()
    {
        raycastManager = GetComponent<ARRaycastManager>();
		hits = new List<ARRaycastHit>();
		gameManager = GameObject.FindWithTag("GameManager").GetComponent<SettingsAndStatsManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 0 || gameManager.stats.creativeMode == false)
			return;
		Touch touch = Input.GetTouch(0);
		if (raycastManager.Raycast(touch.position, hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon) 
			&& touch.phase == TouchPhase.Began)
		{
			Pose pose = hits[0].pose;
			int rand = Random.Range(0, placedObject.Length);
			Instantiate(placedObject[rand], pose.position, Quaternion.identity);
		}
    }
}
