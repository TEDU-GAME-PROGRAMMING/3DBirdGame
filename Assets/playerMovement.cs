using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewayForce = 500f;
    public float jumpForce = 5f;
    public bool isOnGround = true;
    public GameObject RestartButton;
    


    void FixedUpdate()
    {
        //forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rb.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
            isOnGround=false;
        }

        if (rb.position.y < 1f)
        {
            RestartButton.SetActive(true);
        }

    }
    void Update(){
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rb.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
            isOnGround=false;
        }

        if (rb.position.y < 1f)
        {
            RestartButton.SetActive(true);
        }
    }
    private void OnCollisionEnter(Collision collision){
            if(collision.gameObject.CompareTag("zemin")){
                isOnGround = true;
            }
        }
}
