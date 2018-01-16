using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPadGoal : MonoBehaviour {

    GameObject targetPad;
    GameObject RocketShip;
    // Use this for initialization
    void Start ()
    {
		targetPad = GameObject.Find("Target Pad");
        RocketShip = GameObject.Find("Rocket Ship");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Rocket Ship")
        {
            changeTargetPadColorToGreen();
        }
    }

    void changeTargetPadColorToGreen()
    {
        targetPad.GetComponent<Renderer>().material.color = Color.green;
    }

    void changeTargetPadColorToWhite()
    {
        targetPad.GetComponent<Renderer>().material.color = Color.white;
    }
}
