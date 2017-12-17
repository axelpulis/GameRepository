using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class P1_GoalScored_Script : MonoBehaviour {

    public static int p1score = 0;
    public Text scorep1;
    public Text result;
    int scoreShow = 0;



    // Use this for initialization
    void Start () {
        scorep1.text = "Player 1: " + scoreShow.ToString();
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

            scoreShow += 2;
            p1score +=2;
            scorep1.text = "Player 1: " + scoreShow.ToString();
            if (p1score >= 10 && p1score<30)
            {
                scoreShow = 0;
                lManager.LoadNewScene("Level2");
            }
        }
        else if (lManager.getScene() == 2)
        {
            scoreShow += 5;
            p1score +=5;
            scorep1.text = "Player 1: " + scoreShow.ToString();
            if (p1score >= 30 && p1score <50)
            {
                scoreShow = 0;
                lManager.LoadNewScene("Level3");

            }
        }
        else if (lManager.getScene() == 3)
        {
            scoreShow += 10;
            p1score += 10;
            scorep1.text = "Player 1: " + scoreShow.ToString();
            if (p1score >= 50)
            {
                scoreShow = 0;
                lManager.LoadNewScene("EndScreen");
            }
        }
        ball.transform.position = new Vector3(0f, 0f, -2f);
        
        rball.velocity = new Vector2(-6f, 6f);

        Thread.Sleep(1000);

    }
}
