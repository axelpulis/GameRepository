using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseColliderScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collison");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        LevelManager r = new LevelManager();
        r.LoadNewScene("Lose");
        print("Trigger");
    }
}
