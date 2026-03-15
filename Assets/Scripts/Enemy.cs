using UnityEngine;

public class EnemyA : MonoBehaviour
{
    public float speed = 2.0f;
    public Transform target;
    public Rigidbody2D rb;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            var healthComponent = collision.GetComponent<Health>();
            if (healthComponent != null)
            {
                healthComponent.TakeDamage(1);
            }
        }
        if (collision.CompareTag("Weapon"))
        {
            Destroy(gameObject);
        }
    }
}
