using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarateAnimation : MonoBehaviour{
    private Animator m_Animator;
    private bool attack = false;
    private bool idle = true;
    private bool jump = false;



    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {if (Input.GetKeyDown(KeyCode.A)){
        Debug.Log("Toggle Attack");
        jump=false;
        m_Animator.SetBool("Attack1",attack);
        attack=!attack;
        m_Animator.SetBool("Jumping",jump);

    }
    if (Input.GetKeyDown(KeyCode.Space)){
        Debug.Log("Toggle jump");
        attack=false;
        m_Animator.SetBool("Attack1",attack);
        jump=!jump;
        m_Animator.SetBool("Jumping",jump);   

    }
    if (Input.GetKeyDown(KeyCode.Q)){
        Debug.Log("Resetting");
        jump=false;        
        attack=false;
        m_Animator.SetBool("jumping",jump);
        m_Animator.SetBool("Attack1",attack);

        

    }
        
    }
}
