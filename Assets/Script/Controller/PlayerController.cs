using UnityEngine;
using FPS.Player.State;

namespace FPS.Controller
{
    public class PlayerController : MonoBehaviour
    {
        public InputManagerPlayerAction inputManager;
        public Rigidbody rb;

        public float speed;
        public float runSpeed;
        private CharacterStates currentState;
        private IdleStates idleStates;
        private WalkingState walkState;
        private JumpState jumpstate;



        private void Start() {
            idleStates = new IdleStates(this);
            walkState = new WalkingState(this);
            jumpstate = new JumpState(this);

            currentState = idleStates;
            currentState.EnterState();
        }

        private void Update() {
            currentState?.UpdateState();
        }

        public void SwitchStates(CharacterStates nextState)
        {
            currentState?.ExitState();
            currentState = nextState;
            currentState?.EnterState();
        }
    }
}

