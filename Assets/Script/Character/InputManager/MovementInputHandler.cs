using UnityEngine;
using FPS.InputManager;
using FPS.Player.State;
using FPS.Controller;
using FPS.Character.Jump;

namespace FPS
{
    public class MovementInputHandler : InputHandler
    {
        Vector2 playerAction;
        Vector3 move;
        CharacterJump characterJump;
      
        public override void HandleIdleState()
        {
           float magnitude = controller.inputManager.playerInput.Movement.WASD.ReadValue<Vector2>().magnitude;
           if(magnitude > 0)
           {
                controller.SwitchStates(new WalkingState(controller));
           }
        }
        public override void HandleMovementState()
        {
            playerAction = controller.inputManager.playerInput.Movement.WASD.ReadValue<Vector2>();

            move = controller.gameObject.transform.right * playerAction.x + controller.gameObject.transform.transform.forward * playerAction.y;

            move *= controller.inputManager.playerInput.Movement.Run.ReadValue<float>() == 0 ? controller.characterStats.speed : controller.characterStats.runSpeed;
            controller.rb.velocity = new Vector3(move.x, controller.rb.velocity.y, move.z);

            if(playerAction.magnitude == 0)
            {
                controller.SwitchStates(new IdleStates(controller));
            }
        }

        public override void HandleJumpState() => controller.characterJump.Jump();

        public MovementInputHandler(PlayerController _controller) : base(_controller){}
    }
}
