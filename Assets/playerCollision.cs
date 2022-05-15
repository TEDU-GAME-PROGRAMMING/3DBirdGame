using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerMovement movement;
    public GameObject RestartButton;


    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            RestartButton.SetActive(true);
        }
    }


}
