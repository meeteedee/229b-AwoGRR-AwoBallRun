using UnityEngine;

public class WindTrap : MonoBehaviour
{
    public float windForce = 30f; 

    public Vector3 windDirection = new Vector3(0, 0, -1); 
    
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody playerRb = other.GetComponent<Rigidbody>();

            if (playerRb != null)
            {
                Vector3 pushForce = windDirection.normalized * windForce;

                playerRb.AddForce(pushForce, ForceMode.Force);
                
            }
        }
    }
}