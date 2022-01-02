using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Virtubut : MonoBehaviour, IVirtualButtonEventHandler
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Waving");
      

    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Resetting");
    
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
