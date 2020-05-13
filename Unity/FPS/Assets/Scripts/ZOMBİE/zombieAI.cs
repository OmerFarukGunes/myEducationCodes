using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
enum ZombieState
{
    Idle=0,
    Walk=1,
    Dead=2,
    Attack =3 //kodda karıştırmamak için animatorda geçiş şartlarını hangi animasyona kaç değerinde eşitlediysem isim olarak kodda kullanmak istiyoruz ki karışmasın
}
public class zombieAI : MonoBehaviour
{
    //IDLE -WALK -ATTACK -DEAD 4 DURUM VAR. yani animasyonlar arası geçiş yapacan bundan kaynaklı animator lazım sana
    Animator animator;
    NavMeshAgent agent;
    ZombieState zombieState;
    GameObject playerObject;
    void Start()
    {
        playerObject = GameObject.FindWithTag("Player");
        zombieState = ZombieState.Idle;
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        switch (zombieState)
        {
            case ZombieState.Dead:
                killZombie();
                break;
            case ZombieState.Attack:
                Attack();
                break;
            case ZombieState.Walk:
                searchForTarget();
                break;
            case ZombieState.Idle:
                searchForTarget();
                break;
            default:
                break;
        }
    }

    private void Attack()
    {
        setState(ZombieState.Attack);
        agent.isStopped = true; //atak yapmaya geçti.

    }

    private void searchForTarget()
    {
        float distance = Vector3.Distance(transform.position, playerObject.transform.position);
        if (distance <1.5f)
        {
            Attack();
        }
        else if (distance<10f) //zombie ile bizim aramızdaki mesafeyi bul ve 10 dan küçükse ona doğru git.
        {
            MovePlayer();
        }
        else
        {
                 setState(ZombieState.Idle);
               agent.isStopped = true; //bizi görmeyi bıraktığı anda duracak.
        }
    }
    private void setState(ZombieState state)
    { 
        zombieState = state; //hemde kodda set ettik.
        animator.SetInteger("state", (int)state); //hem animatorde
    }
   private void MovePlayer()
    {
        agent.isStopped = false;
        agent.SetDestination(playerObject.transform.position);
        setState(ZombieState.Walk);
    }
    private void killZombie()
    {
        
    }
}
