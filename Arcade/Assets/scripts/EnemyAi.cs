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

    [SerializeField] private GameObject gambling;
    private gambaling gamblingScript;

    [SerializeField] private AudioClip _clip;


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        PC = player.GetComponent<PlayerController>();     
        gamblingScript = gambling.GetComponent<gambaling>();
        
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

    private void OnTriggerEnter(Collider PlayerCell)
    {
        Debug.Log("object enter");

        if (transform.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(_clip, transform.position);
            //PlayerController.PlayerHp = PlayerController.PlayerHp - 1;
            Debug.Log("player health is now" );
            Debug.Log(PlayerController.PlayerHp);

            Destroy(gameObject);

        } 
    }
}


