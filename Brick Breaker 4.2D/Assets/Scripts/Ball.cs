﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public Paddle paddle;
    Vector3 paddleBallDiff;
    bool gameStart = false;

	// Use this for initialization
	void Start () {
        paddleBallDiff = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {        

        if (!gameStart)
        {
            this.transform.position = paddle.transform.position + paddleBallDiff;
        }

        if (Input.GetMouseButtonDown(0) && !gameStart)
        {
            gameStart = true;
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
        }
	}
}
