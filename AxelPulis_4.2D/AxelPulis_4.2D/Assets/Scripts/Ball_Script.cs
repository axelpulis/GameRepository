using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Script : MonoBehaviour {

    
    public Rigidbody2D rbBall;
   
	// Use this for initialization
	void Start () {
        rbBall = GetComponent<Rigidbody2D>();
        rbBall.velocity = new Vector2(6f, 6f);
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
