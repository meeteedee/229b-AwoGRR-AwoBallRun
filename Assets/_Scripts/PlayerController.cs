using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("ตั้งค่าความเร่ง (a)")]
    public float acceleration = 50f; 
    
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
    
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Vector3 force = rb.mass * (movementDirection * acceleration);
        rb.AddForce(force);
    }
}