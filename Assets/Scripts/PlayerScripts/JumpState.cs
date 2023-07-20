using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : CharacterState
{
    public override void EnterState(Player character)    
    {
        base.EnterState(character);
        // C?p nh?t tr?ng thái và animation cho nhân v?t khi vào tr?ng thái Jump
        Debug.Log("Jump State");
        character.Jump();
    }

    public override void Update()
    {
        base.Update();
        // X? lý logic khi nh v?t ?ang ??ng thái Jump
    }

    public override void ExitState()
    {
        base.ExitState();
        // C?p nh?t tr?ng thái và animation cho nhân v?t khi thoát kh?i tr?ng thái Jump
    }

}
    

    
