﻿using UnityEngine;
using System.Collections;

public class WeaponComponent : CacheBehaviour {

    public string idleAnimation;
    public string runAnimation;
    public string jumpAnimation;

    void Start ()
    {
       // spriteRenderer.color = new Color(0f, 0f, 0f, 1f); // Set to opaque black
       SetAnimations();
    }

    void SetAnimations()
    {
        idleAnimation = name + "_Idle";
        runAnimation = name + "_Run";
        jumpAnimation = name + "_Jump";
    }

    public void PlayIdleAnimation()
    {
        animator.speed = IDLE_SPEED;
        animator.Play(Animator.StringToHash(idleAnimation));
    }

    public void PlayRunAnimation()
    {
        animator.speed = RUN_SPEED;
        animator.Play(Animator.StringToHash(runAnimation));
    }

    public void PlayJumpAnimation()
    {
        animator.speed = JUMP_SPEED;
        animator.Play(Animator.StringToHash(jumpAnimation));
    }
}