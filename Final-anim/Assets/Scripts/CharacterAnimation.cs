using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    private Animator anim;
    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    public void Walk(bool move)
    {
        anim.SetBool(AnimationTags.MOVEMENT, move);
    }
    public void Run(bool isRunning)
    {
        anim.SetBool(AnimationTags.RUN, isRunning);
    }
    public void Jump()
    {
        anim.SetTrigger(AnimationTags.JUMP_TRIGGER);
    }
    public void Crouch()
    {
        anim.SetTrigger(AnimationTags.CROUCH_TRIGGER);
    }
    public void Punch_1()
    {
        anim.SetTrigger(AnimationTags.PUNCH_1_TRIGGER);
    }
    public void Punch_2()
    {
        anim.SetTrigger(AnimationTags.PUNCH_2_TRIGGER);
    }
    public void Punch_3()
    {
        anim.SetTrigger(AnimationTags.PUNCH_3_TRIGGER);
    }
    public void Hit()
    {
        anim.SetTrigger(AnimationTags.HIT_TRIGGER);
    }
    public void Breaker()
    {
        anim.SetTrigger(AnimationTags.BREAKER_TRIGGER);
    }
}
