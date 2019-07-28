using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsAndStatsManager : MonoBehaviour
{
	public SettingsAndStats stats;
	public Button createButton;
	public Button shootButton;
	public Text scoreText;
	public GameObject crosshair;
	
	private Color disabledOptionColor = Color.white;
	private Color enabledOptionColor = Color.green;
    // Start is called before the first frame update
    void Start()
    {
		stats.creativeMode = false;
        enableCreativeMode();
    }

	public void enableCreativeMode()
	{
		if (stats.creativeMode == false)
		{
			stats.creativeMode = true;
			createButton.GetComponent<Image>().color = enabledOptionColor;
			shootButton.GetComponent<Image>().color = disabledOptionColor;
			scoreText.enabled = false;
			crosshair.SetActive(false);
		}
	}
	
	public void disableCreativeMode()
	{
		if (stats.creativeMode == true)
		{
			stats.creativeMode = false;
			createButton.GetComponent<Image>().color = disabledOptionColor;
			shootButton.GetComponent<Image>().color = enabledOptionColor;
			scoreText.enabled = true;
			crosshair.SetActive(true);
		}
	}
	
	public void updateScore()
	{
		stats.score +=1;
		scoreText.text = "Score: " + stats.score;
	}
}
