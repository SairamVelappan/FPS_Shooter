using FPS.Controller;

namespace FPS.Player.State
{
    public abstract class CharacterStates
    {
        protected PlayerController controller;
        public CharacterStates(PlayerController _controller)
        {
            this.controller = _controller;
        }

        public abstract void EnterState();
        public abstract void UpdateState();
        public abstract void ExitState();
    }

}