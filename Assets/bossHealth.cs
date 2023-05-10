using UnityEngine;

public class bossHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    private bool isDead;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        if (isDead)
        {
            return;
        }

        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        isDead = true;

        // Play death animation, particle effects, etc.

        Destroy(gameObject, 2f);
    }
}
