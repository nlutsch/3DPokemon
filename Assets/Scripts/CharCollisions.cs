using UnityEngine;
using System.Collections;

public class CharCollisions : MonoBehaviour {
	 
	GameObject cobj;
	HealthBar2 chpb;
	string model = "Charmander Model";
	string attack = "leafAttack";
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
        if (other.gameObject.tag == attack)
           chpb.AdjustcurHealth2(-10);
    }

}