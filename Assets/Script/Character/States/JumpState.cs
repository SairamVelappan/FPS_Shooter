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
            handler = new JumpInputHandler();
        }
        public override void UpdateState()
        {
            handler.HandleJumpState();
        }
        public override void ExitState()
        {

        }
    }
}

