using FPS.Controller;
using UnityEngine;
using System.Threading.Tasks;
using FPS.Player.State;

namespace FPS.Character.Jump
{
    public class ClassJumpCommand : IJumpCommand
    {
        private PlayerController controller;
        public ClassJumpCommand(PlayerController _controller)
        {
            this.controller = _controller;
        }
        public  void Execute()
        {
            Debug.Log("Class Jumped");
            // await WaitingForInput();
        }

        private async Task WaitingForInput()
        {
            while(controller.GroundCheck())
            {
                await Task.Yield();

                if(controller.inputManager.playerInput.Movement.Jump.WasPressedThisFrame())
                {
                    Debug.Log("Class Jumped");
                    // Jump();
                }
            }
            controller.characterJump.SetJumpCommand(new NormalJumpCommand(controller));
        }

        private void Jump()
        {
            controller.rb.AddForce(controller.transform.up * controller.characterStats.jumpForce, ForceMode.VelocityChange);
            controller.SwitchStates(new IdleStates(controller));
        }
    }
}
