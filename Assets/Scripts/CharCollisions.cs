using UnityEngine;
using System.Collections;

public class CharCollisions : MonoBehaviour {
	 
	GameObject cobj;
	HealthBar2 chpb;
	string model = "Charmander Model";
	string attack1 = "leafAttack";
	string attack2 = "Tackle1";
	private Vector3 startPosition = Vector3.zero;
    // Use this for initialization
    void Start()
    {
		cobj = GameObject.Find(model);
		chpb = cobj.GetComponent<HealthBar2>();
		startPosition = transform.position;
    }

    // Update is called once per frame
    void Update(){
		if (chpb.curHealth2 <= 0) {
			transform.position = startPosition + new Vector3(0, 20, 0);
			chpb.AdjustcurHealth2(100);
			chpb.AdjustcurPP2(100);
			if (chpb.lives2 == 1) Destroy(cobj);
			else chpb.AdjLives2(-1);
		}
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == attack1)
            chpb.AdjustcurHealth2(-10);
		if (other.gameObject.tag == attack2)
			chpb.AdjustcurHealth2 (-15);
    }

}