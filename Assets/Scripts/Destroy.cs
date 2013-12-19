using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy(GameObject.Find ("Tackle1"));
		Destroy(GameObject.Find ("Tackle2"));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
