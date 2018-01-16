using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    // Use this for initialization
    private float thrust = 12f;
    Rigidbody _rigidBody;
    private bool isBumped = false;
    GameObject rocketShip;
    private Vector3 position = new Vector3(0.0002282565f, 1.758f, 5.551115e-16f);
    private Quaternion rotation = new Quaternion(0f, 0f, 0f, 0f);
    private float waitingTime = .2f;

    void Start () {
        _rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Fly();
	}

    void Fly()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _rigidBody.AddRelativeForce(Vector3.up * thrust);    
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * 2f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * 2f);
        }
    }

    void RestartRocketPositionAndRotation()
    {
        transform.position = position;
        _rigidBody.angularVelocity = new Vector3(0f, 0f, 0f);
        _rigidBody.velocity = new Vector3(0f, 0f, 0f);
        transform.rotation = Quaternion.identity;
    }


    void OnCollisionEnter(Collision collision)
    {
      if (collision.gameObject.tag == "Obstacle") 
            {
                RestartRocketPositionAndRotation();
            }
 
    }


}
