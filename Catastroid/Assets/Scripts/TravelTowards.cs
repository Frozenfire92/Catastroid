using UnityEngine;
using System.Collections;

public class TravelTowards : MonoBehaviour 
{
    public GameObject target;
    Vector3 position;

	void Start () 
    {
	
	}
	
	void Update () 
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.time);
        //position = transform.position;
        //transform.position = Vector3.Lerp(Vector3.zero, target.transform.position, Time.time);
	}
}
