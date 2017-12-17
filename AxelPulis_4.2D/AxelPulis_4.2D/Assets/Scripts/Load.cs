using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Load : MonoBehaviour {

    public Text result;
    int score1 = P1_GoalScored_Script.p1score;
    int score2 = P2_GoalScore_Script.p2score;
    // Use this for initialization
    void Start () {
        if (score1 > score2)
        {
            result.text = "Player 1 Score: "+score1+"\nPlayer 2 Score: "+score2+ "\nWINNER PLAYER 1!";
        }
        else
        {
            result.text = "Player 2 Score: " + score2 + "\nPlayer 1 Score: " + score1 + "\nWINNER PLAYER 2!";
        }
        P1_GoalScored_Script.p1score = 0;
        P2_GoalScore_Script.p2score = 0;
    }
	
	
    // Update is called once per frame
	void Update () {
		
	}
}
