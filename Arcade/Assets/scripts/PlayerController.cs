
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using static UnityEditor.Experimental.GraphView.GraphView;
using static UnityEngine.GraphicsBuffer;

public class PlayerController : MonoBehaviour
{
    private bool bb = true;
    private Vector3 moveDirection;
    [SerializeField] private float speed = 50f;
    public static float PlayerHp = 10f;
    public float PlayerDmg = 1f;
    private float RotationSpeed = 10f;
    [SerializeField] private GameObject skull;
    [SerializeField] private GameObject gambling;
    private GameObject[] ResetSkulls;
    private gambaling gamblingScript;
    private EnemyAi doot;
    public List<GameObject> lisySkull = new List<GameObject>();
    public int time = 1;
    private wavespawner wavespawner;
    private Rigidbody rb;
    private ConstantForce piew;
    public static int count = 0;
    public bool dede = false;
    void Start()
    {

        doot = skull.GetComponent<EnemyAi>();
        rb = gameObject.GetComponent<Rigidbody>();

        moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        gamblingScript = gambling.GetComponent<gambaling>();
        piew = GetComponent<ConstantForce>();
    }


    async void FixedUpdate()
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

        if (PlayerHp <= 0)
        {
            piew.enabled = true;
        }

        if (wavespawner.spawning = false && Input.GetKey(KeyCode.RightShift))
        {
            ResetSkulls = GameObject.FindGameObjectsWithTag("Skull");
            for (int i = 0; i < ResetSkulls.Length; i++)
            {
                Destroy(ResetSkulls[i]);
            }
        }

        if (transform.position.y > 30)
        {
            transform.position = new Vector3(0f, 0f, 50f);
            wavespawner.count = wavespawner.amountEnemysSpawned;
            piew.enabled = false;
            dede = true;
            wavespawner.time = 0;

            wavespawner.wave = 0;
            ResetSkulls = GameObject.FindGameObjectsWithTag("Skull");
            for (int i = 0; i < ResetSkulls.Length; i++)
            {
                Destroy(ResetSkulls[i]);
            }
            PlayerHp = 10;
            PlayerDmg = 10;

            StartCoroutine(finishingTouch());
            wavespawner.time = 1;
                dede = false;
                Debug.Log("reset");

        }

    }

   
    IEnumerator finishingTouch()
    {
        int num = 0;
        while (true)
        {
            num ++;
            Debug.Log (num);
            Debug.Log("finishing reset");
            yield return new WaitForSeconds(1);
            for (int i = 0; i < ResetSkulls.Length; i++)
            {
                Destroy(ResetSkulls[i]);
            }
            if (num == 2)
            {
                transform.position = new Vector3(1f, 1f, 0.5f);
                Destroy(GameObject.FindGameObjectWithTag("Skull"));
                break;
            }
        }
    }
}



