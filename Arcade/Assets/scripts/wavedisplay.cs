using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class wavedisplay : MonoBehaviour
{
    private wavespawner wavespawner;
    private TMP_Text waveDis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        waveDis = GetComponent<TMP_Text>();
        waveDis.text = "wave: " + wavespawner.wave;

    }
}
