using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEngine;

public class wavespawner : MonoBehaviour
{
    public int amountEnemysSpawned = 2;
    [SerializeField] private GameObject skull;
    public int time = 1;
    public int wave = 0;
    private int waveLocationX;
    private int waveLocationZ;
    private int waveLocationX2;
    private int waveLocationZ2;
    [SerializeField] private GameObject player;
    private PlayerController PC;
    private bool waawa = true;
    private GameObject kill;

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

        amountEnemysSpawned = 2 * wave;

        kill = GameObject.FindGameObjectWithTag("Skull");
        if(kill != null)
        {
            waawa = true;
        }
        if (waawa = true && Input.GetKeyUp(KeyCode.LeftShift))
            {
                wave++;
                StartCoroutine(spawnUnit());

            }
        
    }

    IEnumerator spawnUnit()
    {
        Debug.Log("spawning units");
    int count = 0;

        while (true)
        {
            waawa = false;
            yield return new WaitForSeconds(time);

            Vector3 randomPos = new Vector3(waveLocationX, 2, waveLocationZ);
            Instantiate(skull, randomPos, transform.rotation);
            Debug.Log("enemyspawned");
            
            count++;

            if (count == amountEnemysSpawned) 
            {
               
                break;
            }  
        }
       
    }
        
        
    
}
