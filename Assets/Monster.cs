using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField] private GameObject _DeathEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        BirdGame b = collision.collider.GetComponent<BirdGame>();
        Monster m = collision.collider.GetComponent<Monster>();

        if (b != null)
        {
            Instantiate(_DeathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            return;
        }

        if (m != null)
        {
            return;
        }

        if (collision.contacts[0].normal.y < -0.75 || collision.contacts[0].normal.x > 0.75)
        {
            Instantiate(_DeathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
