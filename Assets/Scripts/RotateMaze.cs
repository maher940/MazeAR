using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMaze : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        

        if(Input.GetKey(KeyCode.D))
        {
            RotateRight();
        }

        if (Input.GetKey(KeyCode.A))
        {
            RotateLeft();
        }

        if (Input.GetKey(KeyCode.W))
        {
            RotateUp();
        }
        if(Input.GetKey(KeyCode.S))
        {
            RotateDown();
        }
    }

    /// <summary>
    /// Rotates the maze in the right direction along the x
    /// </summary>
    public void RotateRight()
    {
        transform.Rotate(new Vector3(1, 0, 0));
    }
    /// <summary>
    /// Rotates the maze in the left direction along the x
    /// </summary>
    public void RotateLeft()
    {
        transform.Rotate(new Vector3(-1, 0, 0));
    }
    /// <summary>
    /// Rotates the Maze up along the y
    /// </summary>
    public void RotateUp()
    {
        transform.Rotate(new Vector3(0, 1, 0));
    }
    /// <summary>
    /// Rotates the Maze down along the y
    /// </summary>
    public void RotateDown()
    {
        transform.Rotate(new Vector3(0, -1, 0));
    }
}
