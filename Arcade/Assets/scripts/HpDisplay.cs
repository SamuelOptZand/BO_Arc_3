using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class HpDisplay : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private PlayerController PlayerController;
    private TMP_Text playerHpDis;
   
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerController = player.GetComponent<PlayerController>();
        playerHpDis = GetComponent<TMP_Text>();

    }

    // Update is called once per frame
    void Update()
    {
            
        playerHpDis.text = "Hp: " + PlayerController.PlayerHp;
    }
}