using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class IceSpawner : MonoBehaviour 
{
    float length = GameController.MAX_LENGTH;
    float width = GameController.MAX_WIDTH;
    float height = GameController.MAX_HEIGHT;
    public int poolSize = 10;

    GameObject icePatch;
    List<GameObject> icePatches;

	void Start () 
    {
        MakeIce();
	}
	
	void Update () 
    {
	
	}

    public void MakeIce()
    {
        icePatches = new List<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {
            icePatches.Add(Instantiate(Resources.Load("Prefabs/IcePatch", typeof(GameObject))) as GameObject);
        }
    }
}
