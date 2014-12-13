using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour 
{
    public GameObject target;
    Vector3 nextPosition = new Vector3(0f, 0f, -GameController.distanceBehindPlayer);

	void Start () 
    {
	
	}
	
	void Update () 
    {
        if (target != null) transform.LookAt(target.transform.position);
        nextPosition.z += GameController.forwardSpeed;
        transform.position = nextPosition;
	}
}
