using Unity.Mathematics;
using UnityEngine;

public class resetmob : MonoBehaviour
{
    public Rigidbody bossRigidbody;
    //public Collider outOfBoundsCollider;
    public GameObject resetPosition;
    public Collider[] OOBCollider;
    public GameObject boss;
    public GameObject boss1;
    public GameObject boss2;
    public GameObject boss3;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.CompareTag("Boss"))
        {
            // Set the enemy's position to (0, 0, 0)
            //other.transform.position = Vector3.zero;
            Debug.Log("match!");
            boss.transform.position = resetPosition.transform.position;
            //boss1.transform.position = resetPosition.transform.position;
           // boss2.transform.position = resetPosition.transform.position;
            boss3.transform.position =  new Vector3 (0f,.5f,0f);
        }
    }
}