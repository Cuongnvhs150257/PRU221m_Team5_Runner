using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : CharacterState
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
        // X? l� logic khi nh v?t ?ang ??ng th�i Jump
    }

    public override void ExitState()
    {
        base.ExitState();
        // C?p nh?t tr?ng th�i v� animation cho nh�n v?t khi tho�t kh?i tr?ng th�i Jump
    }

}
    

    
