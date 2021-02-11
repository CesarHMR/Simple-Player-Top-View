using UnityEngine;

public static class PlayerInput
{
    public static bool AtackInput { get { return Input.GetKeyDown(KeyCode.Mouse0); } }
    public static bool DashInput { get { return Input.GetKeyDown(KeyCode.LeftControl); } }
    public static bool ParryInput { get { return Input.GetKeyDown(KeyCode.Mouse1); } }
    public static float HorizontalInput { get { return Input.GetAxisRaw("Horizontal"); } }
    public static float VerticalInput { get { return Input.GetAxisRaw("Vertical"); } }
}
