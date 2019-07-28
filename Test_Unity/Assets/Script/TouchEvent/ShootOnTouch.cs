using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ShootOnTouch : MonoBehaviour
{
	public GameObject shotObject;
	public GameObject cameraObject;
	private SettingsAndStatsManager gameManager;
	private List<ARRaycastHit> hits;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindWithTag("GameManager").GetComponent<SettingsAndStatsManager>();
		hits = new List<ARRaycastHit>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 0 || gameManager.stats.creativeMode == true)
			return;
		Touch touch = Input.GetTouch(0);
		if (touch.phase == TouchPhase.Began)
		{
			GameObject obj = Instantiate(shotObject, cameraObject.transform.position, Quaternion.identity);
			Destroy(obj, 4.0f);
		}
    }
}
