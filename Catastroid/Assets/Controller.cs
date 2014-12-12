using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour 
{
    Vector3 position = Vector3.zero;
	
	void Update () 
    {
        position.z += 0.1f;
        transform.position = position;
	}
}
