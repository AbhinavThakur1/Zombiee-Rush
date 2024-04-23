using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonZombies : MonoBehaviour
{
    [Header("Zombies")]
    [SerializeField] GameObject Zombie1;
    [SerializeField] GameObject Zombie2;
    [SerializeField] GameObject Zombie3;
    [SerializeField] TMPro.TMP_Text wavenumber;

    [SerializeField] Transform player;
    int spawnzombie;
    float time;
    public int goingby = 0;

    void Update()
    {
        time += Time.deltaTime;
        if(goingby < time)
        {
            wavenumber.text = "wave-" + (goingby / 60).ToString();
            goingby += 60;
            spawnzombie += 7;
        }
        if (FindObjectsByType<ZombieMovement>(FindObjectsSortMode.None).Length < spawnzombie)
        {
            int rnd = Random.Range(1, 4);
            if (rnd == 1)
            {
                Instantiate(Zombie1, new Vector3(Random.Range( player.position.x + 20f, player.position.x + 30f) 
                    , 9.998163f, Random.Range(player.position.z + 20f, player.position.z + 30f)), Quaternion.Euler(0f, 0f, 0f));
            }
            else if (rnd == 2)
            {
                Instantiate(Zombie2,  new Vector3(Random.Range( player.position.x - 20f, player.position.x - 30f) 
                    , 9.998163f, Random.Range(player.position.z + 20f, player.position.z + 30f)), Quaternion.Euler(0f, 0f, 0f));
            }
            else if (rnd == 3)
            {
                Instantiate(Zombie3, new Vector3(Random.Range(player.position.x + 20f, player.position.x + 30f)
                    , 9.998163f, Random.Range(player.position.z - 20f, player.position.z - 30f)), Quaternion.Euler(0f, 0f, 0f));
            }
            else
            {
                Instantiate(Zombie1,  new Vector3(Random.Range( player.position.x - 20f, player.position.x - 30f) 
                    , 9.998163f, Random.Range(player.position.z - 20f, player.position.z - 30f)), Quaternion.Euler(0f, 0f, 0f));
            }
        }
    }
}
