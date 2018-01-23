using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropperScript : MonoBehaviour
{
    public Transform ball;
    public float minXDist;
    public float maxXDist;
    public float speed;
    public int ballMax;
    public int BallCount;
    bool wasMin;
    bool wasMax;
    void Start ()
    {
        wasMin = true;
        wasMax = false;
	}


    void Update()
    {

        float currentX = transform.position.x;

        if (gameObject.transform.position.x == minXDist)
        {
            wasMin = true;
            wasMax = false;
        }
        if (gameObject.transform.position.x == maxXDist)
        {
            wasMin = false;
            wasMax = true;
        }
        if (wasMin)
        {
            currentX++;
            currentX = Mathf.Clamp(currentX, minXDist, maxXDist);
            transform.position = new Vector3(currentX, transform.position.y, transform.position.z);
        }
        if (wasMax)
        {
            currentX--;
            currentX = Mathf.Clamp(currentX, minXDist, maxXDist);
            transform.position = new Vector3(currentX, transform.position.y, transform.position.z);
        }

        
        if(BallCount < ballMax)
        {    
            if (Input.GetKeyDown(KeyCode.Space))
            {
                BallCount++;

                Instantiate(ball, 
                     new Vector3(transform.position.x, transform.position.y, transform.position.z),
                                Quaternion.identity);
            }
        }
     }
}
