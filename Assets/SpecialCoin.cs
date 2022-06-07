using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialCoin : MonoBehaviour
{
    public GameObject allenemies;
    IEnumerator  SlowPlayer(){
        playerMovement.FindObjectOfType<playerMovement>().forwardForce/=2;
        yield return new  WaitForSeconds(2f);
        playerMovement.FindObjectOfType<playerMovement>().forwardForce*=2;
    }
    IEnumerator  FastPlayer(){
        playerMovement.FindObjectOfType<playerMovement>().forwardForce*=2;
        yield return new  WaitForSeconds(2f);
        playerMovement.FindObjectOfType<playerMovement>().forwardForce/=2;
    }
    IEnumerator  DisableEnemy(){
        for (int i = 0; i < allenemies.transform.childCount; i++)
        {
            allenemies.transform.GetChild(i).gameObject.SetActive(false);
        }
        yield return new  WaitForSeconds(2f);
        for (int i = 0; i < allenemies.transform.childCount; i++)
        {
            allenemies.transform.GetChild(i).gameObject.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="slow"){
            Destroy(other.gameObject);
            StartCoroutine(SlowPlayer());
        }
        if(other.gameObject.tag=="fast"){
            Destroy(other.gameObject);
            StartCoroutine(FastPlayer());
        }
        if(other.gameObject.tag=="disableenemy"){
            Destroy(other.gameObject);
            StartCoroutine(DisableEnemy());
        }
        if(other.gameObject.tag=="random"){
            Destroy(other.gameObject);
            int randomindex=Random.Range(1,4);
            if(randomindex==1)
            StartCoroutine(SlowPlayer());
            if(randomindex==2)
            StartCoroutine(FastPlayer());
            if(randomindex==3)
            StartCoroutine(DisableEnemy());
        }
    }
}
