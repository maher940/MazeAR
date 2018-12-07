using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {


   public Vector3 pointA;
   public Vector3 pointB;
    Vector3 direction;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetMouseButtonDown(0))
        {
            pointA = transform.position;
            Camera.main.ScreenToWorldPoint(pointA);
        }

        if(Input.GetMouseButton(0))
        {
            pointB = Input.mousePosition;
            Camera.main.ScreenToWorldPoint(pointB);
            direction = (pointA - pointB).normalized;
            MoveInDirection();
        }
	}

    void MoveInDirection()
    {
        Debug.Log("YPP");
        transform.position = transform.position + direction;
    }
}
