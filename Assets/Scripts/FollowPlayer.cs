using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0,0,-9);
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = player.transform.position;
    }
}
