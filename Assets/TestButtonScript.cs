using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class TestButtonScript : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject vB;
    // Use this for initialization
    void Start () {
        vB = GameObject.Find("Down Rotate");
        vB.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Not");
    }
    // Update is called once per frame
    void Update () {
		
	}
}
