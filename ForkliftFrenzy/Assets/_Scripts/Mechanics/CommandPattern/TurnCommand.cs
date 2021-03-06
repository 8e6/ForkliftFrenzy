﻿using UnityEngine;
using System.Collections;

// Zoe Wall 16/01/17
// Concrete implementation of reverse command to move char forward

public class TurnCommand : Command
{
    private float turnValue;
    private bool moving;

    public TurnCommand(float input, bool mov)
    {
        turnValue = input;
        moving = mov;
    }

    public override void Execute(GameActor actor)
    {
        actor.Turn(turnValue, moving);
    }
}