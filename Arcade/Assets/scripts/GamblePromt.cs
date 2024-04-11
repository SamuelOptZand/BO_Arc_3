using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class GamblePromt : MonoBehaviour
{
    [SerializeField] private GameObject gamble;
    private gambaling Gscript;
    [SerializeField] private GameObject player;
    private PlayerController PC;

    private TMP_Text GamblePromting;
    
    void Start()
    {
        Gscript = gamble.GetComponent<gambaling>();
        PC = player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Gscript.Wallet > 5)
        //{
        //    GamblePromting.text = "PRESS G TO GAMBLE";
        //}
        //else 
        //{
        //    GamblePromting.text = "not enough coins!";
        //}
    }
}
