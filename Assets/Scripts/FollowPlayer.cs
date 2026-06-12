using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = new Vector3(0, 5, -10);
    }


    void LateUpdate()
    {
        transform.position = player.transform.position + player.transform.rotation * offset;
        transform.rotation = player.transform.rotation;
    }
}
