using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FPS;
public class PlayerController : MonoBehaviour
{
    public InputManager inputManager;
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

        currentState = walkState;
    }

    private void Update() {
        currentState?.UpdateState();
    }

    private void SwitchStates(CharacterStates nextState)
    {
        currentState = nextState;
    }
}
