using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    public int Score;
    public Rigidbody rb;
    public Text scoreDisplay;
    

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	
	void Update ()
    {
        scoreDisplay.text = Score.ToString("D4");

        
        
    }
}
