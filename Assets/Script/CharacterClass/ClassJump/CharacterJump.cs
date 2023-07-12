using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS.Character.Jump
{
    public class CharacterJump
    {
        private IJumpCommand jumpCommand;

        public void SetJumpCommand(IJumpCommand command)
        {
            jumpCommand = command;
        }

        public void Jump()
        {
            jumpCommand.Execute();
        }
    }
}
