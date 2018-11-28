using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int score;
    public GameObject ScoreBoard;
    public GameObject ScoreBoard1;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	/*void Update () {
		unneccesary use of performance
	}*/

	public void UpdateScore () {
		//update score
		score++;
		//display score
		ScoreBoard.GetComponent<Score>().DisplayScore(score);
		ScoreBoard1.GetComponent<Score>().DisplayScore(score);
	}
}
