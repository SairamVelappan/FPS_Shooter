using FPS.Controller;
using UnityEngine;

namespace FPS.InputManager
{
    public abstract class InputHandler
    {
        protected PlayerController controller;

        public InputHandler(PlayerController _controller)
        {
            this.controller = _controller;
        }
        
        public abstract void HandleIdleState();
        public abstract void HandleMovementState();
        public abstract void HandleJumpState();

    }
}
