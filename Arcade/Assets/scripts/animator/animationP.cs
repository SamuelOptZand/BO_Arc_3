using Unity.VisualScripting;
using UnityEngine;


public class animation : MonoBehaviour
{
    private Animator ani;
    void Start()
    {

        ani = GetComponent<Animator>();
    }
    void Update()
    {

        resetTriggers();
        //if (Input.GetAxis("Vertical") > 0)
        //{
        //    ani.SetTrigger("Walk");

        //    if (Input.GetAxis("Horizontal") > 0)
        //    {
        //        ani.SetTrigger("Walk");
        //    }
        //    else if(Input.GetAxis("Horizontal") < 0)
        //    {

        //    }
        //    else
        //    {

        //    }
        //}

        if (Input.GetAxis("Vertical") is < 0 or > 0 || Input.GetAxis("Horizontal") is < 0 or > 0 )
        {
            ani.SetTrigger("Walk");
        }
        else
        {
            ani.SetTrigger("Idle");
        }



        ////Check voor verticale input
        //if (Input.GetAxis("Vertical") > 0 || Input.GetAxis("Horizontal") > 0)
        //{
        //    //is de waarde groter dan 0 dan heb je een knop naar boven ingedrukt
        //    //Roep de juiste trigger aan!
        //    ani.SetTrigger("Walk");
        //    ani.ResetTrigger("Idle");
        //    ani.ResetTrigger("WalkR");
        //}
        //else if (Input.GetAxis("Vertical") < 0 || Input.GetAxis("Horizontal") < 0)
        //{
        //    ani.SetTrigger("WalkR");
        //    ani.ResetTrigger("Idle");
        //    ani.ResetTrigger("Walk");
        //}
        //else
        //{
        //    //is de waarde 0 dan heb je niets ingedrukt
        //    //Roep de juiste trigger aan
        //    ani.SetTrigger("Idle");
        //    ani.ResetTrigger("Walk");
        //    ani.ResetTrigger("WalkR");
        //}
    }

    private void resetTriggers()
    {
        ani.ResetTrigger("Idle");
        ani.ResetTrigger("Walk");
        ani.ResetTrigger("WalkR");
    }
}