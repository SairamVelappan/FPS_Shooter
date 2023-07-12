using UnityEngine;
using FPS.Controller;
using FPS.InputManager;

namespace FPS.Player.State
{
    public class IdleStates : CharacterStates
    {
        private InputHandler handler;
        public IdleStates(PlayerController controller) : base(controller) { }

        public override void EnterState()
        {
            handler = new MovementInputHandler(controller);
        }
        public override void UpdateState()
        {
            handler.HandleIdleState();
        }
        public override void ExitState()
        {

        }
    }

}
