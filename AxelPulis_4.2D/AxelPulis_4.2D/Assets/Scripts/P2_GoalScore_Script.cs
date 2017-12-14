using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class P2_GoalScore_Script : MonoBehaviour {

    public static int p2score = 0;

    
    public Text scorep2;
    public Text result;
    // Use this for initialization
    void Start () {

        scorep2.text = "Player 2: " + p2score.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        LevelManager lManager = new LevelManager();
        GameObject ball = GameObject.Find("Ball");

        Rigidbody2D rball = ball.GetComponent<Rigidbody2D>();


       


        if (lManager.getScene() == 1)
        {

            p2score += 2;
            scorep2.text = "Player 2: " + p2score.ToString();
            if (p2score >= 10 && p2score < 30)
            {
                lManager.LoadNewScene("Level2");
            }
        }
        else if (lManager.getScene() == 2)
        {

            p2score += 5;
            scorep2.text = "Player 2: " + p2score.ToString();
            if (p2score >= 30 && p2score < 50)
            {
                lManager.LoadNewScene("Level3");
            }
        }
        else if (lManager.getScene() == 3)
        {
            p2score += 10;
            scorep2.text = "Player 2: " + p2score.ToString();
            if (p2score >= 50)
            {
                
                lManager.LoadNewScene("EndScreen");
            }
        }
        ball.transform.position = new Vector3(0f, 0f, -2f);
        
        Thread.Sleep(2000);
        
        rball.velocity = new Vector2(6f, 6f);



    }
}
