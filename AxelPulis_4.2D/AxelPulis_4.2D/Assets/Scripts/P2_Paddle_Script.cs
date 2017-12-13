using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2_Paddle_Script : MonoBehaviour {
    private Rigidbody2D rbPaddle2;
    // Use this for initialization
    void Start()
    {

        rbPaddle2 = this.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            rbPaddle2.velocity = new Vector2(0f, 6f);
        }
        else if (Input.GetKey(KeyCode.Mouse1))
        {
            rbPaddle2.velocity = new Vector2(0f, -6f);
        }
        else
        {
            rbPaddle2.velocity = new Vector2(0f, 0f);
        }


    }
}
