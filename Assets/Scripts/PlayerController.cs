using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const float speed = 15f;
    private float horizontalInput;
    private const float turnSpeed = 25;
    private float forwardInput;
    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3. forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * horizontalInput * Time.deltaTime * turnSpeed);
    }
}
