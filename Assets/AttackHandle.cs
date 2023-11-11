using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackHandle : MonoBehaviour
{
    Character character;
    PlayerMovement playerMovement;

    Interact target;
    Animator animetor;
    float MeleeAttackRange = 5f;
    private void Awake()
    {
        animetor = GetComponentInChildren<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
        character = GetComponent<Character>();
    }
    internal void Attack(Interact target)
    {
        this.target = target;
        processAttack();
    }
    private void Update()
    {
        if(target != null)
        {
            processAttack();
        }
    }
    private void processAttack()
    {
        float distance = Vector3.Distance(transform.position, target.transform.position);
        if (distance < MeleeAttackRange)
        {
            playerMovement.Stop();
            Character targetOfAttack = target.GetComponent<Character>();
            targetOfAttack.TakeDamage(character.GetStatValue(Statistic.Damage).value);
            animetor.SetTrigger("Attack");
            this.target = null;
        }
        else
        {
            playerMovement.SetDestination(target.transform.position);
        }
    }
}
