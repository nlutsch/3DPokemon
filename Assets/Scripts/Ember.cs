using UnityEngine;
using System.Collections;

public class Ember : Attack {

    GameObject emberPrefab = new GameObject();
    void Start () {
        pref = emberPrefab;
    }

	// Use this for initialization
	void Attack() {
        type = "fire";
        power = 20f;
        range = 10f;
        pp = 5f;
        move = 0f;
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetButtonDown("Joystick 2A1"))
        {
            PerformAttack();
        }
	}
}
