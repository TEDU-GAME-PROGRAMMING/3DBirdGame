using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;

    private float nextAction = 0f,time;
    public float Period = 0.1f;
    private void Start() {
        
    }
    void Update()
    {
        time=Time.timeSinceLevelLoad;
        if (time> nextAction)
        {
            nextAction += Period;
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        }
    }
}

