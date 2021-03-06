﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject Player
    {
        get
        {
            return player;
        }
    }

    [SerializeField] GameObject player;

    Vector3 offset;

	void Start ()
    {
        offset = transform.position - player.transform.position;
	}
	
	void LateUpdate ()
    {
        if(player)
        {
            transform.position = player.transform.position + offset;
        }
	}
}
