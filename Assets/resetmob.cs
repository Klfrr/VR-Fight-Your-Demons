using UnityEngine;

public class resetmob : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.CompareTag("Boss"))
        {
            // Set the enemy's position to (0, 0, 0)
            other.transform.position = Vector3.zero;
            Debug.Log("match!");
        }
    }
}