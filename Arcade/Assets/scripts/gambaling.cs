using UnityEngine;

public class gambaling : MonoBehaviour
{
    public float Wallet = 0;
    public float UpgrHp = 0;
    public float UpgrDmg = 0;

    [SerializeField] private GameObject player;
    private PlayerController PlayerC;


    void Start()
    {
        PlayerC = player.GetComponent<PlayerController>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.G) && Wallet > 5)
        {
            int ran = UnityEngine.Random.Range(0, 100);
            Debug.Log(ran);

            if (ran <= 15)
            {
                Debug.Log("0-15");
                UpgrHp++;
            }
            else if (ran <= 40)
            {
                Debug.Log("15-40");
                UpgrDmg++;
            }
            else if (ran <= 60)
            {
                Debug.Log("40-60");
                Debug.Log("boowomp!");
            }
            else if (ran <= 90)
            {
                Debug.Log("60-90");
                UpgrHp++;
            }
            else if (ran <= 95)
            {
                Debug.Log("90-95");
                UpgrDmg = 0;
                UpgrHp = 0;
            }
            else
            {
                Debug.Log("95-100");
                PlayerC.PlayerHp = 0;
            }
        }
        else 
        {
            Debug.Log("not enough money!!");
        }
    }
}