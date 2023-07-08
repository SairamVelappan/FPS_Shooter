using FPS.Controller;

namespace FPS.InputManager
{
    public abstract class InputHandler
    {
        public abstract void HandleIdleState(PlayerController _controller);
        public abstract void HandleMovementState(PlayerController _controller);
        public abstract void HandleJumpState();

    }
}
