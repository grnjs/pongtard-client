﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilota : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 10f;

	// Use this for initialization
	void Awake ()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(speed, 0f, 0f), ForceMode.Impulse);
	}

    private void Start()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        rb.velocity = new Vector3(speed, 0f, 0f);
        //trans.position += new Vector3(Time.deltaTime * speed, 0f, 0f);
	}

    private void OnCollisionEnter(Collision collision)
    {
        speed = speed * -1; 
    }
}
