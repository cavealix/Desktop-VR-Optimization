using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public GameManager gameManager;
    private Text text;

	// Use this for initialization
	void Start () {
        //gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        text = GetComponentInChildren<Text>();
	}
	
	// Update is called once per frame
	/*void Update () {
	}*/

	public void DisplayScore (int score) {
		//Text text = GetComponentInChildren<Text>();
		text.text = "Score: " + score.ToString(); //gameManager.score.ToString();
	}
}
