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


    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.velocity = movement * speed;
    }

}

