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
    public 
    private Vector3 waveLocationUnder10 = new Vector3 (0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {



        


      
    }
    // Update is called once per frame
    void Update()
    {
        

        amountEnemysSpawned = 5 * wave;


        //if(button pressed)
        StartCoroutine(spawnUnit());

    }

    IEnumerator spawnUnit() {



        int count = 0;
        while (true)
        {

            
            yield return new WaitForSeconds(time);

            Vector3 randomPos = new Vector3(UnityEngine.Random.Range(-1, 1), 0, UnityEngine.Random.Range(-1, 1));
            Instantiate(skull, randomPos, transform.rotation);

            count++;

            if (count == amountEnemysSpawned) {
                break;
                
            }
            wave++;
        }
        


    }
}
