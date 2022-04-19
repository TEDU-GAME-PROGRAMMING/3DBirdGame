using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdGame : MonoBehaviour
{
    private Vector3 _initPos;
    private bool _birdWasLaunched;
    [SerializeField] private float _launchPower = 300;
    private float _timeSittingArround;

    private void Awake()
    {
        _initPos = transform.position;
    }
    //update frame(kuş ekrandan çıkarsa diye)>>
    private void Update()
    {
        GetComponent<LineRenderer>().SetPosition(1, _initPos);
        GetComponent<LineRenderer>().SetPosition(0, transform.position);


        if (_birdWasLaunched && GetComponent<Rigidbody2D>().velocity.magnitude <= 0.1)
        {
            _timeSittingArround = _timeSittingArround + Time.deltaTime;
        }

        if (transform.position.y > 7)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (transform.position.y < -7)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (transform.position.x > 13)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (transform.position.x < -13)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (_timeSittingArround > 4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.magenta;
        GetComponent<LineRenderer>().enabled = true;

    }
    //force ekleme>>/ kuşu tutunca renk değişince bırakınca eski haline getirme>>
    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.white;

        Vector2 directionToInitPos = _initPos - transform.position;
        GetComponent<Rigidbody2D>().AddForce(directionToInitPos * _launchPower);
        GetComponent<Rigidbody2D>().gravityScale = 1;
        _birdWasLaunched = true;
        GetComponent<LineRenderer>().enabled = false;

    }
    //kuşu çekme z kordinatını kaldırma>>
    private void OnMouseDrag()
    {
        Vector3 newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(newPos.x, newPos.y);
    }
}