using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour 
{
    float forwardSpeed = GameController.forwardSpeed;
    Vector3 nextPosition = new Vector3(0f, 0f, -GameController.distanceBehindPlayer);

	void Start () 
    {
	
	}
	
	void Update () 
    {
        nextPosition.z += forwardSpeed;
        transform.position = nextPosition;
	}
}
