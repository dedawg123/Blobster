﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 300.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 9.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }
}
