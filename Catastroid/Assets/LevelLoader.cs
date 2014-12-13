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
		if (Time.time > delay) Application.LoadLevel(level);
	}
}
