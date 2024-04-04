using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class HpDisplay : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private PlayerController PlayerC;

    private TMP_Text playerHpDis;

    
    // Start is called before the first frame update
    void Start()
    {
        PlayerC = player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        playerHpDis = GetComponent<TMP_Text>();

        

        playerHpDis.text = "Hp: " + PlayerC.PlayerHp;
    }
}