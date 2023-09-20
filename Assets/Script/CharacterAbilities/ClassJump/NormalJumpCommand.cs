using UnityEngine;
using FPS.Controller;
using FPS.Player.State;

namespace FPS.Character.Jump
{
    public class NormalJumpCommand : IJumpCommand
    {
        private PlayerController controller;

        private bool isWaitingForInput = true;

        public NormalJumpCommand(PlayerController _controller)
        {
            this.controller = _controller;
        }
        public void Execute()
        {
            // controller.characterStats.readyToJump = false;

            if(!controller.GroundCheck() && !controller.characterStats.readyToJump)
            {
                Debug.Log("CLASS JUMP ACTIVATED");
                controller.characterJump.SetJumpCommand(new ClassJumpCommand(controller));
            }
            else
            if(controller.characterStats.readyToJump)
            {
                 Jump();           
            }           
        }

        private void Jump()
        {
            controller.rb.AddForce(controller.transform.up * controller.characterStats.jumpForce, ForceMode.VelocityChange);
            controller.SwitchStates(new IdleStates(controller));
        }
    }
}
