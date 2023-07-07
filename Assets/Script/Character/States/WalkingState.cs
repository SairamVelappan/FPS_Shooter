using UnityEngine;
using FPS.Controller;
using FPS.InputManager;

namespace FPS.Player.State
{
    public class WalkingState : CharacterStates
    {
        public WalkingState(PlayerController controller) : base(controller) { }
        private InputHandler handler;
        
        public override void EnterState()
        {
            handler = new WalkingInputHandler();
        }
        public override void UpdateState()
        {
            handler.HandleMovementState(controller);
        }
        public override void ExitState()
        {

        }
    }
}

