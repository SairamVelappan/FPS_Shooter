using UnityEngine;
public class IdleStates : CharacterStates
{
    public IdleStates(PlayerController controller) : base(controller) { }
    public override void UpdateState()
    {
        // controller.inputManager.playerControl.Movement.WASD.ReadValue<Vector2>().ma
    }
}
