using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    List<GameObject> bullets;
    int currentBullet;

    float nextFireTime;
    float fireDelay = 0.1f;

    void Start()
    {
        bullets = new List<GameObject>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire") && Time.time > nextFireTime) Fire();
    }

    public void Fire()
    {
        if (bullets.Count < 1) MakeBullets();
        bullets[currentBullet].transform.position = transform.position;
        bullets[currentBullet].SetActive(true);
        //Give the bullet motion
        currentBullet++; if (currentBullet >= bullets.Count) currentBullet = 0;
        nextFireTime += fireDelay;
    }

    void MakeBullets()
    {
        bullets = new List<GameObject>();
        for (int i = 0; i < 10; i++)
        {
            bullets.Add(Instantiate(Resources.Load("Prefabs/Bullet", typeof(GameObject))) as GameObject);
            bullets[i].gameObject.SetActive(false);
        }
    }
}
