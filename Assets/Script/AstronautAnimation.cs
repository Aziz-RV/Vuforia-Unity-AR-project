using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AstronautAnimation : MonoBehaviour,IVirtualButtonEventHandler{
    private GameObject vb;
    public Animator m_Animator;
    private bool drill = false;
    private bool idle = true;
    private bool wave = false;

  
    private float movementSpeed = 5f;




    // Start is called before the first frame update
    void Start()
    {
        vb= GameObject.Find("VirtualButton");
   
        vb.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        m_Animator.GetComponent<Animator>();
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb){
        Debug.Log("Waving");
        m_Animator.SetBool("IsWaving", true);
      


    }
    public void OnButtonReleased(VirtualButtonBehaviour vb){
        Debug.Log("Resetting");
        m_Animator.SetBool("IsWaving", false);


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)){
            Debug.Log("Drilling");
            m_Animator.SetBool("IsDrilling", true);

        }
        if (Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("Resetting");
            m_Animator.SetBool("IsDrilling",false);
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, 0);

        
    }
}
