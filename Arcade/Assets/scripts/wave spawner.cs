using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.VisualScripting;
using UnityEngine;

public class wavespawner : MonoBehaviour
{
    public static int amountEnemysSpawned = 2;
    [SerializeField] public GameObject skull;
    public static int time = 1;
    public static int wave = 0;
    private int waveLocationXfront;
    private int waveLocationZfront;
    private int waveLocationXright;
    private int waveLocationZright;
    private int waveLocationXleft;
    private int waveLocationZleft;
    private int waveLocationXback;
    private int waveLocationZback;

    private int wutWall;
    private int waveLocationx;
    private int waveLocationz;
    [SerializeField] private GameObject player;
    private PlayerController PC;
    private bool waawa = false;
    private Array kill;
    public static bool spawning = false;
    public static int count = 0;
    public bool dede = true;
    private bool womp = true;
    void Start()
    {
        PC = player.GetComponent<PlayerController>();
        kill = null;
    }
    void Update()
    {
        waveLocationXfront = UnityEngine.Random.Range(-30, 26);
        waveLocationZfront = UnityEngine.Random.Range(24, 20);

        waveLocationXright = UnityEngine.Random.Range(26, 22);
        waveLocationZright = UnityEngine.Random.Range(24, -24);

        waveLocationZback = UnityEngine.Random.Range(-24, -20);
        waveLocationXback = UnityEngine.Random.Range(26, 32);

        waveLocationZleft = UnityEngine.Random.Range(-24, 24);
        waveLocationXleft = UnityEngine.Random.Range(32, 30);
      
        amountEnemysSpawned = 2 * wave;
       kill = GameObject.FindGameObjectsWithTag("Skull");
        if (kill.Length == 0 && spawning == false)
        {
            waawa = true;
        }
        else
        {
            waawa = false;
            
        }
   
        if (waawa == true && Input.GetKeyUp(KeyCode.LeftShift))
            {
                wave++;
                StartCoroutine(spawnUnit());
                
            }
       
    }

    public IEnumerator spawnUnit()
    {
        
       count = 0;
       
        while (PC.dede == false)
        {
            wutWall = UnityEngine.Random.RandomRange(0, 100);
            if(wutWall >= 25)
            {
                waveLocationx = waveLocationXfront;
                waveLocationz = waveLocationZfront;
            }else if(wutWall >= 50)
            {
                waveLocationx = waveLocationXleft;
                waveLocationz = waveLocationZleft;
            }else if (wutWall >= 75)
            {
                waveLocationx = waveLocationXright;
                waveLocationz = waveLocationZright;
            }
            else
            {
                waveLocationx = waveLocationXback;
                waveLocationz = waveLocationZback;
            }
            spawning = true;
            yield return new WaitForSeconds(time);

            Vector3 randomPos = new Vector3(waveLocationx, 2, waveLocationz);
            Instantiate(skull, randomPos, transform.rotation);
            
            
            count++;
            
            if (count >= amountEnemysSpawned) 
            {
               spawning = false;
                break;
            }  
        }
       
    }

 


}
