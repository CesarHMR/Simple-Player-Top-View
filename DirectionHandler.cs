using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(Rigidbody2D))]
public class DirectionHandler : MonoBehaviour
{
    Direction _currentDirection;
    Rigidbody2D rb;

    private void Start() => rb = GetComponent<Rigidbody2D>();

    public Direction GetDirection()
    {
        float x = rb.velocity.normalized.x;
        float y = rb.velocity.normalized.y;

        if (x > y)
        {
            if (x > 0)
            {
                _currentDirection = Direction.Right;
            }
            else
            {
                _currentDirection = Direction.Left;
            }
        }
        else if (y > x)
        {
            if (y > 0)
            {
                _currentDirection = Direction.Up;
            }
            else
            {
                _currentDirection = Direction.Down;
            }
        }

        return _currentDirection;
    }

    public Vector2 GetDirectionVector2()
    {
        Direction direction = GetDirection();

        switch (direction)
        {
            case Direction.Up:
                return Vector2.up;

            case Direction.Down:
                return Vector2.down;

            case Direction.Left:
                return Vector2.left;

            case Direction.Right:
                return Vector2.right;

            default:
                return Vector2.down;
        }
    }
}
public enum Direction { Up, Down, Left, Right }