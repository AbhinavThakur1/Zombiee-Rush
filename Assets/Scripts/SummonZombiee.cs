using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SummonZombiee : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI wave;
    [SerializeField] Transform position;
    [SerializeField] List<GameObject> Zombbie;
    [SerializeField] List<GameObject> zombbieWavetwo;
    [SerializeField] List<GameObject> zombbieWavethree;
    [SerializeField] List<GameObject> zombbieWavefour;
    [SerializeField] List<GameObject> zombbieWavefive;
    [SerializeField] List<GameObject> zombbieWavesix;
    [SerializeField] List<GameObject> zombbieWaveseven;
    [SerializeField] List<GameObject> zombbieWaveeight;
    [SerializeField] List<GameObject> zombbieWavenine;
    [SerializeField] List<GameObject> zombbieWaveten;
    [SerializeField] float time;
    [SerializeField] public int health;

    private void Start()
    {
        health = dataTransfer.health;
    }
    void Update()
    {
        time += 1f * Time.deltaTime;
        waveLevel((int)time);
        zombieIncrease();
    }

    private void zombieIncrease()
    {
        transform.position = position.position;
        foreach (GameObject zombie in Zombbie)
        {
            if (zombie.activeSelf == false)
            {
                zombie.GetComponent<ZombieMovement>().health = health;
                zombie.GetComponent<BoxCollider>().enabled = true;
                zombie.transform.position = zombie.GetComponent<ZombieMovement>().position.transform.position;
                zombie.transform.rotation = transform.rotation;
                zombie.SetActive(true);
                zombie.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = false;
            }
        }
        if (time >= 60f)
        {
            foreach (GameObject zombie in zombbieWavetwo)
            {
                if (zombie.activeSelf == false)
                {
                    zombie.GetComponent<ZombieMovement>().health = health;
                    zombie.GetComponent<BoxCollider>().enabled = true;
                    zombie.transform.position = zombie.GetComponent<ZombieMovement>().position.transform.position;
                    zombie.transform.rotation = transform.rotation;
                    zombie.SetActive(true);
                    zombie.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = false;
                }
            }
        }
        if (time >= 120f)
        {
            foreach (GameObject zombie in zombbieWavethree)
            {
                if (zombie.activeSelf == false)
                {
                    zombie.GetComponent<ZombieMovement>().health = health;
                    zombie.GetComponent<BoxCollider>().enabled = true;
                    zombie.transform.position = zombie.GetComponent<ZombieMovement>().position.transform.position;
                    zombie.transform.rotation = transform.rotation;
                    zombie.SetActive(true);
                    zombie.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = false;
                }
            }
        }
        if (time >= 180f)
        {
            foreach (GameObject zombie in zombbieWavefour)
            {
                if (zombie.activeSelf == false)
                {
                    zombie.GetComponent<ZombieMovement>().health = health;
                    zombie.GetComponent<BoxCollider>().enabled = true;
                    zombie.transform.position = zombie.GetComponent<ZombieMovement>().position.transform.position;
                    zombie.transform.rotation = transform.rotation;
                    zombie.SetActive(true);
                    zombie.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = false;
                }
            }
        }
        if (time >= 240f)
        {
            foreach (GameObject zombie in zombbieWavefive)
            {
                if (zombie.activeSelf == false)
                {
                    zombie.GetComponent<ZombieMovement>().health = health;
                    zombie.GetComponent<BoxCollider>().enabled = true;
                    zombie.transform.position = zombie.GetComponent<ZombieMovement>().position.transform.position;
                    zombie.transform.rotation = transform.rotation;
                    zombie.SetActive(true);
                    zombie.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = false;
                }
            }
        }
        if (time >= 300f)
        {
            foreach (GameObject zombie in zombbieWavesix)
            {
                if (zombie.activeSelf == false)
                {
                    zombie.GetComponent<ZombieMovement>().health = health;
                    zombie.GetComponent<BoxCollider>().enabled = true;
                    zombie.transform.position = zombie.GetComponent<ZombieMovement>().position.transform.position;
                    zombie.transform.rotation = transform.rotation;
                    zombie.SetActive(true);
                    zombie.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = false;
                }
            }
        }
        if (time >= 360f)
        {
            foreach (GameObject zombie in zombbieWaveseven)
            {
                if (zombie.activeSelf == false)
                {
                    zombie.GetComponent<ZombieMovement>().health = health;
                    zombie.GetComponent<BoxCollider>().enabled = true;
                    zombie.transform.position = zombie.GetComponent<ZombieMovement>().position.transform.position;
                    zombie.transform.rotation = transform.rotation;
                    zombie.SetActive(true);
                    zombie.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = false;
                }
            }
        }
        if (time >= 420f)
        {
            foreach (GameObject zombie in zombbieWaveeight)
            {
                if (zombie.activeSelf == false)
                {
                    zombie.GetComponent<ZombieMovement>().health = health;
                    zombie.GetComponent<BoxCollider>().enabled = true;
                    zombie.transform.position = zombie.GetComponent<ZombieMovement>().position.transform.position;
                    zombie.transform.rotation = transform.rotation;
                    zombie.SetActive(true);
                    zombie.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = false;
                }
            }
        }
        if (time >= 480f)
        {
            foreach (GameObject zombie in zombbieWavenine)
            {
                if (zombie.activeSelf == false)
                {
                    zombie.GetComponent<ZombieMovement>().health = health;
                    zombie.GetComponent<BoxCollider>().enabled = true;
                    zombie.transform.position = zombie.GetComponent<ZombieMovement>().position.transform.position;
                    zombie.transform.rotation = transform.rotation;
                    zombie.SetActive(true);
                    zombie.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = false;
                }
            }
        }
        if (time >= 540f)
        {
            foreach (GameObject zombie in zombbieWaveten)
            {
                if (zombie.activeSelf == false)
                {
                    zombie.GetComponent<ZombieMovement>().health = health;
                    zombie.GetComponent<BoxCollider>().enabled = true;
                    zombie.transform.position = zombie.GetComponent<ZombieMovement>().position.transform.position;
                    zombie.transform.rotation = transform.rotation;
                    zombie.SetActive(true);
                    zombie.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = false;
                }
            }
        }
    }

    void waveLevel(int time)
    {
        if (time == 0)
        {
            wave.text = "Wave:- 1";
        }
        else if (time > 60 && time < 62)
        {
            wave.text = "Wave:- 2";
        }
        else if (time > 120 && time < 122)
        {
            wave.text = "Wave:- 3";
        }
        else if (time > 180 && time < 182)
        {
            wave.text = "Wave:- 4";
        }
        else if (time > 240 && time < 242)
        {
            wave.text = "Wave:- 5";
        }
        else if (time > 300 && time < 302)
        {
            wave.text = "Wave:- 6";
        }
        else if (time > 360 && time < 362)
        {
            wave.text = "Wave:- 7";
        }
        else if (time > 420 && time < 422)
        {
            wave.text = "Wave:- 8";
        }
        else if(time > 480 && time < 482)
        {
            wave.text = "Wave:- 9";
        }
        else if(time > 540 && time < 542)
        {
            wave.text = "Wave:- 10";
        }
    }

}