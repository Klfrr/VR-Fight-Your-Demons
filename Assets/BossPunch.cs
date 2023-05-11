using UnityEngine;

public class BossPunch : MonoBehaviour
{
    public float damageAmount = 10f; // Adjust this as needed
    public float punchForce = 500f;
    // This assumes that your VR controller is set up to fire a trigger input when you punch
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider we hit has a BossHealth component
        bossHealth bossHealth = other.GetComponent<bossHealth>();
        Rigidbody bossRigidbody = other.GetComponent<Rigidbody>();

        // If the collider has a BossHealth component, subtract damageAmount from its health
        if (bossHealth != null && bossRigidbody != null)
        {
            bossHealth.TakeDamage((int)damageAmount);

            // Apply force to the boss's rigidbody to make it ragdoll
            Vector3 punchDirection = transform.forward;
            bossRigidbody.AddForce(punchDirection * punchForce);
        }
    }
}