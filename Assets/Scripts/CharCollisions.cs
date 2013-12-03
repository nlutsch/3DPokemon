using UnityEngine;
using System.Collections;

public class CharCollisions : MonoBehaviour {

    public HealthBar2 hp2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "leaf")
            hp2.AdjustcurHealth2(10);
    }

}
