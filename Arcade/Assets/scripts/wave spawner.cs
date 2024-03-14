using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wavespawner : MonoBehaviour
{
    public int amountEnemysSpawned = 5;
    public GameObject skull;
    public int time = 1;
    public int wave = 0;
    private int waveLocationX;
    private int waveLocationZ;
    private int waveLocationX2;
    private int waveLocationZ2;

    // Start is called before the first frame update
    void Start()
    {
        waveLocationX = UnityEngine.Random.Range(-1, 1);
        waveLocationZ = UnityEngine.Random.Range(-1, 1);
        waveLocationX2 = UnityEngine.Random.Range(-1, 1);
        waveLocationZ2 = UnityEngine.Random.Range(-1, 1);
    }
    // Update is called once per frame
    void Update()
    {
        

        amountEnemysSpawned = 5 * wave;
        

        //if(button pressed && wave < 10)
        StartCoroutine(spawnUnit());
        //else
        
            amountEnemysSpawned = amountEnemysSpawned / 2;
            StartCoroutine(spawnUnit2());
            StartCoroutine(spawnUnit());

    }

    IEnumerator spawnUnit() {



        int count = 0;
        while (true)
        {

            
            yield return new WaitForSeconds(time);

            Vector3 randomPos = new Vector3(waveLocationX, 0, waveLocationZ);
            Instantiate(skull, randomPos, transform.rotation);

            count++;

            if (count == amountEnemysSpawned) {
                break;
                
            }
            
        }
        wave++;


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
