using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{
    float x, y;
    public float speed;
    public SpriteRenderer characterSprite;
    Animator animator;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        CharacterMovement();
        CharacterFlipX();
        CharacterJump();
    }

    private void CharacterMovement()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(x, y).normalized * Time.deltaTime * speed;

        animator.SetBool("IsWalking", new Vector3(x, y).magnitude > 0f);
    }

    private void CharacterFlipX()
    {
        if (Input.mousePosition.x > Screen.width / 2)
            characterSprite.flipX = false;
        else
            characterSprite.flipX = true;
    }

    private void CharacterJump()
    {
        animator.SetBool("IsJumping", Input.GetButtonDown("Jump"));
    }
}