using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(MovementHandler))]
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    MovementHandler movementHandler;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //Set in the Inspector
        //rb.gravityScale = 0;
        //rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
        //rb.constraints = RigidbodyConstraints2D.FreezeRotation;

        movementHandler = GetComponent<MovementHandler>();
    }

    private void Update()
    {
        Vector2 movement = new Vector2(PlayerInput.HorizontalInput, PlayerInput.VerticalInput);
        movementHandler.MoveRigidbody(rb, movement, speed);
    }
}
