using UnityEngine;
using FPS.Controller;
using FPS.Player.State;

namespace FPS.Character.Jump
{
    public class NormalJumpCommand : IJumpCommand
    {
        private PlayerController controller;

        public NormalJumpCommand(PlayerController _controller)
        {
            this.controller = _controller;
        }
        public void Execute()
        {
            if(controller.GroundCheck())
            {
                controller.rb.AddForce(controller.transform.up * controller.characterStats.jumpForce, ForceMode.Impulse);
                controller.SwitchStates(new IdleStates(controller));
            }           
        }
    }
}
