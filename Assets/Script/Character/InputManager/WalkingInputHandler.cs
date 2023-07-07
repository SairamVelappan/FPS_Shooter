using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FPS.Controller;

namespace FPS.InputManager
{
    public class WalkingInputHandler : InputHandler
    {    
        Vector2 playerAction;
        Vector3 move;
        public override void HandleIdleState()
        {
            
        }

        public override void HandleMovementState(PlayerController controller)
        {
            playerAction = controller.inputManager.playerControl.Movement.WASD.ReadValue<Vector2>();

            move = controller.gameObject.transform.right * playerAction.x + controller.gameObject.transform.transform.forward * playerAction.y;

            move *= controller.inputManager.playerControl.Movement.Run.ReadValue<float>() == 0 ? controller.speed : controller.runSpeed;
            controller.rb.velocity = new Vector3(move.x, controller.rb.velocity.y, move.z);
        }
        public override void HandleJumpState()
        {
            
        }
    }
}
