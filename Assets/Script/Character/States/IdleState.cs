using UnityEngine;
using FPS.Controller;

namespace FPS.Player.State
{
    public class IdleStates : CharacterStates
    {
        public IdleStates(PlayerController controller) : base(controller) { }

        public override void EnterState()
        {

        }
        public override void UpdateState()
        {
            // controller.inputManager.playerControl.Movement.WASD.ReadValue<Vector2>().ma
        }
        public override void ExitState()
        {

        }
    }

}
