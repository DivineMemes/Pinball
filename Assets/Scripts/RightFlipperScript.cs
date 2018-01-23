using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*public float rotationspeed = 1.0f;
   public Vector3 idleRotation;
   public Vector3 fullRotation;

   private float rotationInterval
   {
       get
       {
           return Vector3.Angle(idleRotation, fullRotation) / rotationspeed;
       }
   }
   private float rotationTimer;
   private Quaternion initialRotation;

   void Start()
   {
       initialRotation = transform.rotation;
   }

   void Update ()
   {
       if (Input.GetButton("Fire1"))
       {
           rotationTimer += Time.deltaTime;
       }
       else
       {
           rotationTimer -= Time.deltaTime;
       }
       rotationTimer = Mathf.Clamp(rotationTimer, 0.0f, rotationInterval);

       transform.rotation = Quaternion.Euler(Vector3.Slerp(idleRotation, fullRotation, rotationTimer / rotationInterval));
   }*/


public class RightFlipperScript : MonoBehaviour
{
   public float force;

   public Rigidbody rb;
   void Start()
   {
       rb = GetComponent<Rigidbody>();
   }

   void Update()
   {
       if(Input.GetMouseButtonDown(0))
       {
           rb.AddForce(Vector3.left*2, ForceMode.Impulse);
       }
        if (Input.GetMouseButtonUp(0))
        {
            rb.AddForce(Vector3.right*10, ForceMode.Impulse);
        }

    }
}

