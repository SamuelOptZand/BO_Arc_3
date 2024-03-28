
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private Vector3 moveDirection;
    [SerializeField] private float speed = 50f;
    [SerializeField] private float rotSpeed = 50f;
    [SerializeField] private GameObject gambling;
    private gambaling gamblingScript;


    public float PlayerHp = 10f;
    public float PlayerDmg = 1f;


    private float RotationSpeed = 10f;

    private Rigidbody rb;
    private ConstantForce piew;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

        moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        gamblingScript = gambling.GetComponent<gambaling>();
        piew = GetComponent<ConstantForce>();
    }


    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.velocity = movement * speed;

        moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        Vector3 lookDirection = moveDirection + gameObject.transform.position;
        gameObject.transform.LookAt(lookDirection);


        //attack and health part
        PlayerHp = PlayerHp + gamblingScript.UpgrHp;
        PlayerDmg = PlayerDmg + gamblingScript.UpgrDmg;



        if (PlayerHp == 0)
        {
            piew.enabled = true;
        }

    }

}
