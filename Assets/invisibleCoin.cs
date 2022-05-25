using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisibleCoin : MonoBehaviour
{

    public GameObject ObjectFind;
    public float vanishTime;



    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 0);
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.name== "player")
        {
            gameObject.tag = "Obstacle";
            //Obstacle.collider.isTrigger=true;
            //ObjectFind = GameObject.FindGameObjectWithTag("Obstacle");
        // for (int i = 0; i < ObjectFind.Length; i++)
        //     Destroy(ObjectFind[i]);
            Destroy(gameObject);
        }
    }
}
