using UnityEngine;
using System.Collections;

public class TargetPlanetController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit planet");
        if (GameController.forwardSpeed < GameController.DESTROY_SPEED)
        {
            Destroy(other.gameObject);
            GameController.controller.dead = true;
            GameController.forwardSpeed = 0.1f;
        }
        else
        {
            GameController.controller.won = true;
        }
    }
}
