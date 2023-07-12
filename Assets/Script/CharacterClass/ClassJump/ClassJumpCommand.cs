using FPS.Controller;
using UnityEngine;

namespace FPS.Character.Jump
{
    public class ClassJumpCommand : IJumpCommand
    {
        private PlayerController controller;
        public ClassJumpCommand(PlayerController _controller)
        {
            this.controller = _controller;
        }
        public void Execute()
        {
            Debug.Log("ClassJump Performed");
        }
    }
}
