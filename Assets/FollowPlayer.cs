using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        //adding the player position vector and the offset vector
        transform.position = player.position + offset;
    }
}
