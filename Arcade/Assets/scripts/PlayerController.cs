using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Maak 2 variabelen beschikbaar in de inspector
    [SerializeField] private float speed = 50f;
    [SerializeField] private float rotSpeed = 50f;

    //Maak een variabele voor je rigidbody
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 positionUpdate = new Vector3 (Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f, Input.GetAxis("Vertical") * speed * Time.deltaTime);
        transform.position += positionUpdate; 

        transform.Rotate(new Vector3(0, Input.GetAxis("rotate") * rotSpeed * Time.deltaTime, 0));
         
        

    }

}

