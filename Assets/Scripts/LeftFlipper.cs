using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftFlipper : MonoBehaviour {

    public float force;

    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(Vector3.right * 2, ForceMode.Impulse);
        }
        if (Input.GetMouseButtonUp(0))
        {
            rb.AddForce(Vector3.left * 10, ForceMode.Impulse);
        }

    }
}
