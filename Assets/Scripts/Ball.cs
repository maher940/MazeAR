using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ball : MonoBehaviour {

    /// <summary>
    /// Original position of ball
    /// </summary>
    [SerializeField]
    private GameObject startingPos;
    /// <summary>
    /// Text for instructions and if you one
    /// </summary>
    [SerializeField]
    private Text text;
    /// <summary>
    /// Original text
    /// </summary>
    private string ogtext;
	// Use this for initialization
	void Start () {
        ogtext = text.text;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    /// <summary>
    /// Checks to see if the ball hits the goal and if it does it calls the Coroutine WinnerText
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Goal"))
        {
       
            transform.position = startingPos.transform.position;
            StartCoroutine(WinnerText());
        }
    }
    /// <summary>
    /// Checks to see if the ball leaves the boundaries and if it does it resets the position
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Boundary"))
        {
            transform.position = startingPos.transform.position;
            
        }
    }
    /// <summary>
    /// Tells the user they won for two seconds
    /// </summary>
    /// <returns></returns>
    IEnumerator WinnerText()
    {
        text.text = "Winner";
        yield return new WaitForSeconds(3);
        text.text = ogtext;
    }
}
