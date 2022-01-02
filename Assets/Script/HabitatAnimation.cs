using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HabitatAnimation : MonoBehaviour
{
    private Animator m_Animator;
    private bool openDoor = false;
    private bool idle = true;
    private bool openhatch = false;



    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("Toggle hatch");
            openDoor = true;
            m_Animator.SetBool("IsDoorOpen", openDoor);
            m_Animator.SetBool("IsHatchOpen", openhatch);

        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Toggle Door");
            openhatch = true;
            m_Animator.SetBool("IsHatchOpen", openhatch);
            m_Animator.SetBool("IsDoorOpen", openDoor);

        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("Resetting");
            openDoor= false;
            openhatch= false;
            m_Animator.SetBool("IsHatchOpen", openhatch);
            m_Animator.SetBool("IsDoorOpen", openDoor);





        }

    }
}
