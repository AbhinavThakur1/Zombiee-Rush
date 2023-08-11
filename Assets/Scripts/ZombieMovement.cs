using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieMovement : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    Transform target;
    public float health;
    Animator animator;
    [SerializeField] float stopingDistance = 1;
    public GameObject position;


    [Header("Audio")]
    public AudioClip attack;
    public AudioClip damaged;
    public AudioClip run;
    public AudioClip die;
    AudioSource AS;


    void Start()
    {
        health = dataTransfer.health;
        navMeshAgent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
        animator = GetComponent<Animator>();
        AS = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (health > 0)
        {
            animator.SetBool("idle", true);
            navMeshAgent.stoppingDistance = stopingDistance;
            navMeshAgent.speed = 2f;
            float distance = Vector3.Distance(target.position, transform.position);
            faceTarget();
            if (navMeshAgent.SetDestination(target.position))
            {
                animator.SetBool("run", true);
                AS.playOnAwake = true;
            }
            if (distance <= stopingDistance)
            {
                navMeshAgent.isStopped = true;
                animator.SetBool("attack", true);
                animator.SetBool("run", false);
                AS.playOnAwake = false;
            }
            else
            {
                navMeshAgent.isStopped = false;
                animator.SetBool("attack", false);
            }
        }
        else if (health <= 0)
        {
            navMeshAgent.isStopped = true;
            GetComponent<BoxCollider>().enabled = false;
            animator.SetBool("attack", false);
            animator.SetBool("run", false);
            animator.SetBool("death", true);
            animator.SetBool("gothit", false);
            AS.playOnAwake = false;
        }
    }

    void faceTarget()
    {
        Vector3 dir = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(dir.x, transform.position.y, dir.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, 5f * Time.deltaTime);
    }

    public void gotHit()
    {
        if (health > 0)
        {
            health -= 50;
            animator.SetBool("attack", false);
            animator.SetBool("run", false);
            if (!animator.GetBool("gothit"))
            {
                animator.SetBool("gothit", true);
            }
        }
    }

    public void playrunsound() => AS.PlayOneShot(run);

    public void playdiesound() => AS.PlayOneShot(die);

    public void stopGothit() => animator.SetBool("gothit", false);

    public void playattacksound()
    {
        AS.PlayOneShot(attack);
        FindObjectOfType<PlayerMovement>().health -= 20;
    }

    public void playgothitsound() => AS.PlayOneShot(damaged);

    public void disappear()
    {
        FindAnyObjectByType<counter>().countDeath();
        if (FindObjectOfType<PlayerMovement>().health < 200)
        {
            FindObjectOfType<PlayerMovement>().health += 50;
            if(FindObjectOfType<PlayerMovement>().health > 200)
            {
                FindObjectOfType<PlayerMovement>().health = 200;
            }
        }
        FindObjectOfType<PlayerMovement>().ammo += 50;
        gameObject.SetActive(false);
    }

}