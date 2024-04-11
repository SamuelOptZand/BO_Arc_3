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

        if (Input.GetAxis("Vertical") is < 0 or > 0 || Input.GetAxis("Horizontal") is < 0 or > 0 )
        {
            ani.SetTrigger("Walk");
        }
        else if (Input.GetMouseButtonDown(0))
        {
            ani.SetTrigger("Punch");
            //Debug.Log("Pressed left-click");
        }
        else
        {
            ani.SetTrigger("Idle");
        }
    }

    private void resetTriggers()
    {
        ani.ResetTrigger("Idle");
        ani.ResetTrigger("Walk");
    }
}