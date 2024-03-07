using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 50f;
    [SerializeField] private float rotSpeed = 50f;

    private float RotationSpeed = 10f;

    private Rigidbody rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }


    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //Vector3 positionUpdate = new Vector3 (Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f, Input.GetAxis("Vertical") * speed * Time.deltaTime);
        //transform.position += positionUpdate;

        //transform.Rotate(new Vector3(0, Input.GetAxis("rotate") * rotSpeed * Time.deltaTime, 0));

        rb.transform.Translate(new Vector3(horizontal, 0f, vertical) * speed * Time.deltaTime);


        //transform.Rotate(0, Input.GetAxis("Mouse X") * RotationSpeed, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        speed = speed * -3f;
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("test");
        speed = 50f;
    }

    
}


