using UnityEngine;

[DisallowMultipleComponent]
public class MovementHandler : MonoBehaviour
{
    //Call On Update
    public void MoveRigidbody(Rigidbody2D rb, Vector2 movemet, float speed)
    {
        Vector2 velocity = movemet.normalized * speed;
        rb.velocity = velocity;
    }
}