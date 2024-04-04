using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class wavespawner : MonoBehaviour
{
    public int amountEnemysSpawned = 5;
    [SerializeField] private GameObject skull;
    public int time = 1;
    public int wave = 0;
    private int waveLocationX;
    private int waveLocationZ;
    private int waveLocationX2;
    private int waveLocationZ2;
    [SerializeField] private GameObject player;
    private PlayerController PC;

    void Start()
    {
        PC = player.GetComponent<PlayerController>();
    }
    void Update()
    {
        waveLocationX = UnityEngine.Random.Range(-10, 10);
        waveLocationZ = UnityEngine.Random.Range(15, 25);
        waveLocationX2 = UnityEngine.Random.Range(-1, 1);
        waveLocationZ2 = UnityEngine.Random.Range(-1, 1);

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            StartCoroutine(spawnUnit());
            Debug.Log(PlayerController.PlayerHp);
        }
        
    }

    IEnumerator spawnUnit()
    {
        Debug.Log("spawning units");
    int count = 0;

        while (true)
        {
            yield return new WaitForSeconds(time);

            Vector3 randomPos = new Vector3(waveLocationX, 2, waveLocationZ);
            Instantiate(skull, randomPos, transform.rotation);
            Debug.Log("enemyspawned");
            Debug.Log(PlayerController.PlayerHp);
            count++;

            if (count == amountEnemysSpawned) 
            {
                break;
            }  
        }
       
    }

    IEnumerator spawnUnit2()
    {
        int count = 0;
        while (true)
        {
            yield return new WaitForSeconds(time);
            Vector3 randomPos = new Vector3(waveLocationX2, 0, waveLocationZ2);
            Instantiate(skull, randomPos, transform.rotation);
            count++;

            if (count == amountEnemysSpawned)
            {
                break;
            }
        }
    }
}
