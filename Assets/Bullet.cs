using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;
    Rigidbody rb;

    playerMovement PM;
    Vector3 moveDirection;

    void Start()
    {
        rb.velocity = new Vector3(moveDirection.x, moveDirection.y, moveDirection.z);
    }

    void onCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }


}
