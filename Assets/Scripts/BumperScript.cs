using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperScript : MonoBehaviour
{
    public BallScript ball;
	
	void Start ()
    {
		
	}


    void Update ()
    {
		
	}


    void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag == "Ball")
        {
            ball.rb.AddForce(Vector3.Reflect(ball.rb.velocity, other.contacts[0].normal), ForceMode.Force);
        }
        ball.Score += 10;
    }
}
