using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : CharacterState
{
    private Animator animator;
    public override void EnterState(Player character)
    {
        base.EnterState(character);
        // C?p nh?t trng thái và animation choân v?t khi vào trng thái Idle
        animator.Play("Player_Idle");
    }

    public override void Update()
    {
        base.Update();
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Idle Sat");
            character.ChangeState(new JumpState());
        }
    }



}
