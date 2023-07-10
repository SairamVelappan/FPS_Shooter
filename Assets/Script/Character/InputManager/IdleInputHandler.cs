using UnityEngine;
using FPS.Controller;
using FPS.Player.State;

namespace FPS.InputManager
{
    public class IdleInputHandler : InputHandler
    {
        public override void HandleIdleState(PlayerController controller)
        {
            float magnitude = controller.inputManager.playerControl.Movement.WASD.ReadValue<Vector2>().magnitude;
            if(magnitude > 0)
                controller.SwitchStates(new WalkingState(controller));
            else
                Debug.Log("IDLE");
        }

        public override void HandleMovementState(PlayerController _controller)
        {
            
        }
        public override void HandleJumpState()
        {
            
        }
    }
}
