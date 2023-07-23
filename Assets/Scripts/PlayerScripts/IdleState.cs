using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : CharacterState
{
    private Animator animator;

    public IdleState(Player character)
    {
        this.character = character;
    }

    public override void EnterState(Player character)
    {   
        base.EnterState(character);
        character.Idle();
    }

    public override void Update()
    {
        base.Update();

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began || Input.GetKeyDown(KeyCode.W))
        {
            character.ChangeState(new JumpState());
        }
    }



}
