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

