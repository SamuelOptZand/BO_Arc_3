using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{

    
    private GameObject target;
    private Vector3 targetPosition;
    [SerializeField] private GameObject player;
    private PlayerController PC;
    public int health = 2;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        PC = player.GetComponent<PlayerController>();
        
    }
   
    // Update is called once per frame
    void Update()
    {
        float step = 5f * Time.deltaTime;

        targetPosition = new Vector3(target.transform.position.x, 1, target.transform.position.z);

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);

        transform.LookAt(targetPosition);

        
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other )
    {
        //Debug.Log("object enter");
        if (other.gameObject == target)
        {
            //PC.PlayerHp--;
            //Debug.Log("player health is now" );
            //Debug.Log(PC.PlayerHp);
            //Destroy(gameObject);

        } 
    }
}


