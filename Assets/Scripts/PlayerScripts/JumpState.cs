
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState :  CharacterState
{
    

    public override void EnterState(Player character)    
    {
        base.EnterState(character);
        // C?p nh?t tr?ng th�i v� animation cho nh�n v?t khi v�o tr?ng th�i Jump
        Debug.Log("Jump State");
        character.Jump();
    }

    public override void Update()
    {   
        base.Update();

        
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("cannot jump more");
        }

        character.checkJump();

        //if(character.isGrounded == true)
        //{
        //    ExitState();
        //}
        if (Input.GetKeyDown(KeyCode.D))
        {
            character.ChangeState(new IdleState(character));
        }
    }

    public override void ExitState()
    {   

        character.ChangeState(new IdleState(character));

    }

}
    

    
