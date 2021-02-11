using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(DirectionHandler))]
public class DirectionalAnimation : MonoBehaviour
{
    //Use blend three
    [SerializeField] Animator anim;
    DirectionHandler directionHandler;

    private void Start() => directionHandler = GetComponent<DirectionHandler>();


    private void Update()
    {
        UpdateAnim();
    }

    void UpdateAnim()
    {
        Vector2 direction = directionHandler.GetDirectionVector2();

        anim.SetFloat("Horizontal", direction.x);
        anim.SetFloat("Vertical", direction.y);
    }
}
