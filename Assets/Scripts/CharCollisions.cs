using UnityEngine;
using System.Collections;

public class CharCollisions : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "leafAttack") { 
           GameObject charmanderObject = GameObject.Find("Charmander Model");
		   HealthBar2 adjhealthscript = charmanderObject.GetComponent<HealthBar2>();
		   adjhealthscript.AdjustcurHealth2(-1);
		}	
    }

}
