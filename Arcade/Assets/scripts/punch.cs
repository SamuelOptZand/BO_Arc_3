using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class punch : MonoBehaviour
{
    [SerializeField] private GameObject skull;
    private EnemyAi doot;
    public GameObject CubeP;
    
    void Start()
    {
        doot = skull.GetComponent<EnemyAi>();
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("gaysex!");
            StartCoroutine(Punching());
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("enter");

        if (transform.CompareTag("Skull"))
        {
            doot.health -= 1;
            // Perform actions when the punch collides with an enemy
            Debug.Log("Hit an enemy!");
            // You can add health deduction, play sound effects, etc.
            //gamblingScript.Wallet += 1;
        }
    }
    IEnumerator Punching()
    {
        int time = 3;
        

        while (true)
        {
            Debug.Log("click");
            CubeP.SetActive(true);
            yield return new WaitForSeconds(time);
            
            CubeP.SetActive(false);
            break;
        }
    }
}

