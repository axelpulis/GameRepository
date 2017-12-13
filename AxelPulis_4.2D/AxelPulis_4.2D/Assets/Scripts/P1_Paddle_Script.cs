using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1_Paddle_Script : MonoBehaviour {

    private Rigidbody2D rbPaddle1;

    // Use this for initialization
	void Start () {

        rbPaddle1 = this.GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            rbPaddle1.velocity = new Vector2(0f, 6f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rbPaddle1.velocity = new Vector2(0f, -6f);
        }
        else
        {
            rbPaddle1.velocity = new Vector2(0f, 0f);
        }
		

    }
}
