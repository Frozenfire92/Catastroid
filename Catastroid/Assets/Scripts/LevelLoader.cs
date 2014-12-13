using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour 
{
	public string level;
	public float delay;

	void Start () 
	{
	
	}

	void Update () 
	{
        GameController.controller.Won = false;
        GameController.controller.Dead = false;
        GameController.controller.Health = GameController.MAX_HEALTH;
		if (Time.timeSinceLevelLoad > delay) Application.LoadLevel(level);
	}
}
