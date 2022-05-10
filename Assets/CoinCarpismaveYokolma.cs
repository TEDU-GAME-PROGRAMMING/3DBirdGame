using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCarpismaveYokolma : MonoBehaviour
{
    public AudioSource coinses;
 
    void Start()
    {
        coinses= GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            
         
            
           Destroy (GameObject.FindWithTag("Coinler"));
;          

        }
    }

}