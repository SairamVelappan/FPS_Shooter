using FPS.Controller;
using FPS.InputManager;

namespace FPS.Player.State
{
    public class JumpState : CharacterStates
    {
        private InputHandler handler;
        public JumpState(PlayerController controller) : base(controller) { }

        public override void EnterState()
        {
            handler = new MovementInputHandler(controller);
            handler.HandleJumpState();
        }
        public override void UpdateState()
        {
            
        }
        public override void ExitState()
        {

        }

    }
}

