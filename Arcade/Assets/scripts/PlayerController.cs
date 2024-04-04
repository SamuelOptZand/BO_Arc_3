
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using static UnityEditor.Experimental.GraphView.GraphView;
using static UnityEngine.GraphicsBuffer;

public class PlayerController : MonoBehaviour
{
    private Vector3 moveDirection;
    [SerializeField] private float speed = 50f;
    [SerializeField] private float rotSpeed = 50f;
    [SerializeField] private GameObject gambling;
    [SerializeField] private GameObject skull;
    private gambaling gamblingScript;
    private EnemyAi doot;

    public float PlayerHp = 10f;
    public float PlayerDmg = 1f;
    public int time = 1;

    private float RotationSpeed = 10f;

    private Rigidbody rb;
    private ConstantForce piew;

    void Start()
    {
        doot = skull.GetComponent<EnemyAi>();
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
        PlayerHp += gamblingScript.UpgrHp;
        PlayerDmg += gamblingScript.UpgrDmg;



        if (PlayerHp == 0)
        {
            piew.enabled = true;
        }

         

    }
    private void OnTriggerStay(Collider other)
    {
        
        if (Input.GetMouseButtonDown(0)) 
        {         
            if (other.tag == "Skull")
            doot.health-- ;
            
            }
        }
    }


