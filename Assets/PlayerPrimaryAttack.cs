using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrimaryAttack : PlayerState
{
    private int noOfClicks = 0;
    private float lastClickedTime = 0;
    public float maxComboDelay;

    public PlayerPrimaryAttack(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();

        if (Time.time - lastClickedTime > maxComboDelay)
        {
            noOfClicks = 0;
        }

        lastClickedTime = Time.time;
        noOfClicks++;

        if  (noOfClicks == 1)
        {
            player.anim.SetBool("Attack1", true);
        }

        else if (noOfClicks == 2)
        {
            player.anim.SetBool("Attack2", true);
        }

        else if (noOfClicks == 3)
        {
            player.anim.SetBool("Attack3", true);
        }
        else if (noOfClicks > 3)
        {
            player.anim.SetBool("Attack1", false);
            player.anim.SetBool("Attack2", false);
            player.anim.SetBool("Attack3", false);
            noOfClicks = 0;
        }

        //if (triggerCalled)
        //{
        //    stateMachine.ChangeState(player.idleState);
        //}
    }
}
