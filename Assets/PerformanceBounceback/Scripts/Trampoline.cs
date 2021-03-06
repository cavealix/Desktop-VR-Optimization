﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour {

    public ParticleSystem pSystem;
    public GameManager scoreScript;

	// Use this for initialization
	void Start () {
        //set and hold onto particle system once
		pSystem = GetComponentInChildren<ParticleSystem>();
	}
	
	// Update is called once per frame
	/*void Update () {

	}*/

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Throwable"))
        {
            //Centralize score logic to GameManager
            scoreScript.UpdateScore();
            //play particles
            pSystem.Play();
            
            //get current score
            /*scoreScript = GameObject.Find("GameManager").GetComponent<GameManager>();
            pSystem = GetComponentInChildren<ParticleSystem>();

            //Score Point
            //scoreScript.score++;
            //Particle effect
            pSystem.Play();*/

            //Debug.Log("Trampoline Hit");
        }

    }
}
