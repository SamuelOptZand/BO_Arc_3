using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    private GameObject target;
    private Vector3 targetPosition;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float step = 5f * Time.deltaTime;

        targetPosition = new Vector3(target.transform.position.x, 1, target.transform.position.z);

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);

        transform.LookAt(targetPosition);
    }
}


