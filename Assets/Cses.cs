using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cses : MonoBehaviour
{
    public AudioSource ses;
    void Start()
    {
        ses = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            ses.Play();




        }
    }

}