﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScript : MonoBehaviour {

    Rigidbody2D rb2d;

	void Start () {

        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = transform.up * 10;

	}
	
}
