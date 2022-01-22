﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firetrap : MonoBehaviour
{
    [SerializeField] private float damage;

    [Header("Firetrap Timers")]
    [SerializeField] private float activationDelay;
    [SerializeField] private float activeTime;
    private Animator anim;
    private SpriteRenderer spriteRend;

    private bool triggered; // when the trap gets triggered
    private bool active; // when the trap is active and can hurt the player

    private void Awake()
    {
        anim = GetComponent<Animator>();
        spriteRend = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if (!triggered)
                StartCoroutine(ActivateFiretrap());
            

            if (active)
                collision.GetComponent<PlayerLife>();
        }
    }

    private IEnumerator ActivateFiretrap()
    {
        triggered = true;

        yield return new WaitForSeconds(activationDelay);
        active = true;
        yield return new WaitForSeconds(activeTime);
        active = false;
        triggered = false;
    }
}
