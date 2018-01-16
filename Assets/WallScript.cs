using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{

    Rigidbody _rigidBody1;
    BoxCollider boxcollider;
    private bool isBumped = false;
    GameObject targetPad;
    GameObject rocketShip;
    private Vector3 position = new Vector3(-0.01140663f, -0.01200116f, 5.329071e-15f);
    private float waitingTime = .5f;

    // Use this for initialization
    void Start ()
    {
        targetPad = GameObject.Find("Target Pad");
        rocketShip = GameObject.Find("Rocket Ship");
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if (isBumped == false)
        {
            if (collision.gameObject.name == "Rocket Ship")
            {
                isBumped = true;
            }
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (isBumped == true)
        {
            isBumped = false;
            transformTargetToColorWhite();
        }
    }

    void transformTargetToColorWhite()
    {
        targetPad.GetComponent<Renderer>().material.color = Color.white;
    }
}
