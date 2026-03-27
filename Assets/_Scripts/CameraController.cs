using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player; 

    public Vector3 offset = new Vector3(0, 8f, -10f); 

    public float turnSpeed = 3f;

    void LateUpdate()
    {
        if (player != null)
        {
            float horizontalInput = Input.GetAxis("Mouse X") * turnSpeed;

            offset = Quaternion.AngleAxis(horizontalInput, Vector3.up) * offset;

            transform.position = player.position + offset;
            transform.LookAt(player.position);
        }
    }
}