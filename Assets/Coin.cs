using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "player")
        {
            Score.coinAmount += 1;
            Destroy(gameObject);
        }
    }
}
