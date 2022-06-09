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
        rb=this.gameObject.GetComponent<Rigidbody>();
        rb.AddForce(this.gameObject.transform.forward*20,ForceMode.VelocityChange);
        Destroy(gameObject, 2f);
    }

    void onCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }


}
