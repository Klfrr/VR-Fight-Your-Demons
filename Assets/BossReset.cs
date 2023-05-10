using UnityEngine;

public class BossReset : MonoBehaviour
{
    public Rigidbody bossRigidbody;
    //public Collider outOfBoundsCollider;
    public GameObject resetPosition;
    public Collider[] OOBCollider;
    public GameObject boss;
    public GameObject boss1;
    public GameObject boss2;
    public GameObject boss3;

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the boss collided with the out-of-bounds collider
        foreach (Collider outOfBoundsCollider in OOBCollider)
        {
            if (collision.collider == outOfBoundsCollider)
            {
                // Reset the boss's position and velocity

                boss.transform.position  = resetPosition.transform.position;
                boss1.transform.position = resetPosition.transform.position;
                boss2.transform.position = resetPosition.transform.position;
                boss3.transform.position = resetPosition.transform.position;
                bossRigidbody.position = resetPosition.transform.position;
                bossRigidbody.velocity = Vector3.zero;
                bossRigidbody.angularVelocity = Vector3.zero;
            }
        }
        
    }
}