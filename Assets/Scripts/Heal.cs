using UnityEngine;

public class Heal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            var healthComponent = collision.GetComponent<Health>();
            if (healthComponent != null && healthComponent.currentHealth < healthComponent.maxHealth)
            {
                healthComponent.Heal(1);
                Destroy(gameObject);
            }
        }
    }
}
