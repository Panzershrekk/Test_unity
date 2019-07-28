using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
	public CubeStats stats;
	public Material[] materials;
	
	private MeshRenderer cubeRenderer;
	private SettingsAndStatsManager gameManager;
	
    // Start is called before the first frame update
    void Start()
    {
		cubeRenderer = this.GetComponent<MeshRenderer>();
		gameManager = GameObject.FindWithTag("GameManager").GetComponent<SettingsAndStatsManager>();
    }
	void takeDamage()
	{
		stats.hp -= 1;
		if (stats.hp <= 0)
			die();
		cubeRenderer.material = stats.hp == 2 ? materials[1] : materials[2];
		transform.localScale -= transform.localScale * stats.shrinkRatio;
	}
	
	void die()
	{
		gameManager.updateScore();
		Destroy(gameObject);
	}
	
	void OnCollisionEnter (Collision col)
    {
		Destroy(col.gameObject);
		takeDamage();
    }
}
