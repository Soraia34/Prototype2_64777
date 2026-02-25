using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public const float speed = 15f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3. forward * Time.deltaTime * speed);
    }
}
