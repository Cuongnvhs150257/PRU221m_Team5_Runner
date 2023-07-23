using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterState
{
    protected Player character;

    public virtual void Start()
    {
    }

    public virtual void EnterState(Player character)
    {
        this.character = character;

    }

    public virtual void Update()
    {
    }

    public virtual void ExitState()
    {
    }
}
