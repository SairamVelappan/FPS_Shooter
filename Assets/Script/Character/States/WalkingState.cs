using UnityEngine;
public class WalkingState : CharacterStates
{
    public WalkingState(PlayerController controller) : base(controller) { }

    Vector2 movement;Vector3 move;
    public override void UpdateState()
    {
        movement = controller.inputManager.playerControl.Movement.WASD.ReadValue<Vector2>();

        move = controller.gameObject.transform.right * movement.x + controller.gameObject.transform.transform.forward * movement.y;

        move *= controller.inputManager.playerControl.Movement.Run.ReadValue<float>() == 0 ? controller.speed : controller.runSpeed;
        controller.rb.velocity = new Vector3(move.x, controller.rb.velocity.y, move.z);
    }
}
