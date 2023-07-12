using UnityEngine;
using FPS.Player.State;
using FPS.Character.Jump;
using FPS.SO;

namespace FPS.Controller
{
    public class PlayerController : MonoBehaviour
    {
        #region Variables
            public InputManagerPlayerAction inputManager;
            public CharacterJump characterJump;
            public CharacterStates currentState;
            public CharacterStats characterStats;
            public Rigidbody rb;
            public IdleStates idleStates;
            private WalkingState walkState;
            private JumpState jumpstate;
        #endregion


        private void Start() {
            characterJump = new CharacterJump();
            characterJump.SetJumpCommand(new NormalJumpCommand(this));
            
            idleStates = new IdleStates(this);
            walkState = new WalkingState(this);
            jumpstate = new JumpState(this);

            currentState = idleStates;
            currentState.EnterState();

            inputManager.playerControl.Movement.Jump.performed +=_=> OnJump();
        }

        private void Update(){
            GroundCheck();
        }
        private void FixedUpdate() => currentState?.UpdateState();
        private void OnJump() => SwitchStates(jumpstate);

        public void SwitchStates(CharacterStates nextState)
        {
            currentState?.ExitState();
            currentState = nextState;
            currentState?.EnterState();
        }

        public bool GroundCheck() 
        {
            return Physics.Raycast(transform.GetChild(0).position, Vector3.down, 2 * 0.5f + 0.2f);
        }
    }
}

