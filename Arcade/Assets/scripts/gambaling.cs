using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("gambaling has started");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.G))
        {
            int ran = UnityEngine.Random.Range(0, 100);
            Debug.Log(ran);
            if (ran <= 15)
            {
                Debug.Log("0-15");
             }else if (ran <= 40)
            {
                Debug.Log("15-40");
            }else if(ran <= 60)
            {
                Debug.Log("40-60");
            }else if(ran <= 90)
            {
                Debug.Log("60-90");
            }else if(ran <= 95)
            {
                Debug.Log("90-95");
            }
            else
            {
                Debug.Log("95-100");
            }

        }
       
    }
}
