using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private CharacterStates currentState;

    private IdleStates idleStates;
    private WalkingState walkState;
    private JumpState jumpstate;

    private void Start() {
        idleStates = new IdleStates(this);
        walkState = new WalkingState(this);
        jumpstate = new JumpState(this);

        currentState = idleStates;
    }

    private void Update() {
        currentState?.UpdateState();
    }

    private void SwitchStates(CharacterStates nextState)
    {
        currentState = nextState;
    }
}
