using UnityEngine;
using System.Collections;

public class CharCollisions : MonoBehaviour {


	GameObject charmanderObject;
	HealthBar2 adjhealthscript;
	// Use this for initialization
	void Start () {
		charmanderObject = GameObject.Find("Charmander Model");
		adjhealthscript = charmanderObject.GetComponent<HealthBar2>();
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "leafAttack") { 
		   adjhealthscript.AdjustcurHealth2(-5);
		}	
    }

}
