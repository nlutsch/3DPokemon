using UnityEngine;
using System.Collections;

public class CharCollisions : MonoBehaviour {
	 
	GameObject cobj;
	HealthBar2 chpb;
	string model = "Charmander Model";
	string attack1 = "leafAttack";
	string attack2 = "Tackle1";
    // Use this for initialization
    void Start()
    {
		cobj = GameObject.Find(model);
		chpb = cobj.GetComponent<HealthBar2>();
    }

    // Update is called once per frame
    void Update(){
		if (chpb.curHealth2 <= 0) {
			Destroy(cobj);
		}
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == attack1)
            chpb.AdjustcurHealth2(-10);
		if (other.gameObject.tag == attack2)
			chpb.AdjustcurHealth2 (-15);
		Debug.Log(other.gameObject.tag);
    }

}