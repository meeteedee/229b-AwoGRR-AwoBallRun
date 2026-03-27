using UnityEngine;

public class StarCoinItem : MonoBehaviour
{
    public int scoreValue = 10;
    

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager manager = FindObjectOfType<GameManager>();
            if (manager != null)
            {
                manager.AddScore(scoreValue);
            }

            Destroy(gameObject);
        }
    }
}