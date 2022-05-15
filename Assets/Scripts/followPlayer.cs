
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    // public Vector2 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (player.position.x, 0, -10);
    }
}
