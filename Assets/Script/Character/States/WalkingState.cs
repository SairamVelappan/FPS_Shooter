using UnityEngine;
using FPS.Controller;
using FPS.InputManager;

namespace FPS.Player.State
{
    public class WalkingState : CharacterStates
    {
        private InputHandler handler;
        public WalkingState(PlayerController controller) : base(controller) { }
        
        public override void EnterState()
        {
            handler = new MovementInputHandler(controller);
        }
        public override void UpdateState()
        {
            handler.HandleMovementState();
        }
        public override void ExitState()
        {

        }
    }
}

